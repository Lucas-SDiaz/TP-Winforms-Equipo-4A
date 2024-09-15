using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TP_CATÁLOGO
{
    public partial class FrmAgregarArticulo : Form
    {

        private Articulo articulo = null;
        public FrmAgregarArticulo()
        {
            InitializeComponent();
            btnAgregarmas.Visible = false;
        }

        public FrmAgregarArticulo(Articulo articulo)
        {
            InitializeComponent();

            this.articulo = articulo;
            this.Text = "Modificar artículo";
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                articulo.CodigoArticulo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                //articulo.Imagen.Url = txtImagen.Text;
                if (!string.IsNullOrWhiteSpace(txtPrecio.Text))
                {
                    decimal precio = decimal.Parse(txtPrecio.Text);
                    articulo.Precio = decimal.Round(precio, 2);
                }

                if (articulo.Id > 0)
                {
                    negocio.modificar(articulo);

                    if (!string.IsNullOrWhiteSpace(txtImagen.Text))
                    {
                        int imagenPrincipal = negocio.obtenerImagenPrincipal(articulo.Id);

                        if (imagenPrincipal > 0)
                        {
                            negocio.modificarImagen(imagenPrincipal, txtImagen.Text);
                        }
                        else
                        {
                            negocio.agregarImagen(articulo.Id, txtImagen.Text);
                        }
                    }

                    MessageBox.Show("Modificado correctamente");
                }
                else
                {
                    if (!negocio.validarCodigoExistente(articulo.CodigoArticulo))
                    {
                        MessageBox.Show("El codigo ya existe");
                        return;
                    }

                    negocio.agregar(articulo);

                    if (!string.IsNullOrWhiteSpace(txtImagen.Text))
                    {
                        int idArticulo = negocio.obtenerIdArticuloPorCodigo(txtCodigo.Text);
                        negocio.agregarImagen(idArticulo, txtImagen.Text);
                    }

                    MessageBox.Show("Agregado correctamente");
                }

                this.DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FrmAgregarArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                cboMarca.DataSource = marcaNegocio.listar();
                //cboMarca.ValueMember = "id";
                //cboMarca.DisplayMember = "nombre";
                //cboMarca.SelectedIndex = 1;

                cboCategoria.DataSource = categoriaNegocio.listar();
                //cboCategoria.ValueMember = "id";
                //cboCategoria.DisplayMember = "nombre";
                //cboCategoria.SelectedIndex = 1;

                //if (articulo != null)
                //{
                //    txtCodigo.Text = articulo.CodigoArticulo;
                //    txtNombre.Text = articulo.Nombre;
                //    txtDescripcion.Text = articulo.Descripcion;
                //    txtImagen.Text = articulo.Imagen.Url;
                //    txtPrecio.Text = Convert.ToString(articulo.Precio);

                //    cboMarca.SelectedValue = articulo.Marca.ID_Marca;
                //    cboCategoria.SelectedValue = articulo.Categoria.ID_Categoria;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtImagen_Leave(object sender, EventArgs e)
        {
            try
            {
                pbImagen.Load(txtImagen.Text);
            }
            catch (Exception)
            {
                pbImagen.Load("https://bub.bh/wp-content/uploads/2018/02/image-placeholder.jpg");
            }
        }
    }
}
