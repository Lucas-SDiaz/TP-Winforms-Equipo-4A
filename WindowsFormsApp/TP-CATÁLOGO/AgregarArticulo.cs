using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
        private List<Imagen> imagenes = null;


        int index = 0;

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
            ArticuloNegocio negocio = new ArticuloNegocio();
            ImagenNegocio imgNegocio = new ImagenNegocio();

            try
            {
                if (articulo == null)
                {
                    articulo = new Articulo();
                    articulo.Imagenes = new List<Imagen>();
                }
               

                articulo.CodigoArticulo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;

                if (!string.IsNullOrWhiteSpace(txtPrecio.Text))
                {
                    decimal precio = decimal.Parse(txtPrecio.Text);
                    articulo.Precio = decimal.Round(precio, 2);
                }

                if (articulo.Id > 0)
                {
                    negocio.modificar(articulo);

                    //if (!string.IsNullOrWhiteSpace(txtURL.Text))
                    //{
                    //    int imagenPrincipal = negocio.obtenerImagenPrincipal(articulo.Id);

                    //    if (imagenPrincipal > 0)
                    //    {
                    //        negocio.modificarImagen(imagenPrincipal, txtImagen.Text);
                    //    }
                    //    else
                    //    {
                    //        negocio.agregarImagen(articulo.Id, txtImagen.Text);
                    //    }
                    //}

                    MessageBox.Show("Modificado correctamente");
                }
                else
                {
                    if (!negocio.validarCodigoExistente(articulo.CodigoArticulo))
                    {
                        MessageBox.Show("El codigo ya existe");
                        return;
                    }
                    else
                    {
                        negocio.agregar(articulo);
                    }
                    


                    if (!string.IsNullOrWhiteSpace(txtURL.Text))
                    {
                        int idArticulo = negocio.obtenerIdArticuloPorCodigo(txtCodigo.Text);
                        imgNegocio.agregarImagen(idArticulo, txtURL.Text);
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

            if (articulo == null)
            {
                btnAnterior.Visible = false;
                btnSiguiente.Visible = false;
                btnAgregarmas.Visible = false;
            }
            else
            {
                imagenes = articulo.Imagenes;                
                lblImagen.Visible = false;
                txtURL.Visible = false;
            }
            try
            {
                cboMarca.DataSource = marcaNegocio.listar();
                //cboMarca.ValueMember = "Id";
                //cboMarca.DisplayMember = "Descripcion";
                //cboMarca.SelectedIndex = 1;

                cboCategoria.DataSource = categoriaNegocio.listar();
                //cboCategoria.ValueMember = "Id";
                //cboCategoria.DisplayMember = "Descripcion";
                //cboCategoria.SelectedIndex = 1;

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.CodigoArticulo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    CargarImagen(articulo.Imagenes[0].Url);


                    txtPrecio.Text = Convert.ToString(articulo.Precio);

                    cboMarca.SelectedValue = articulo.Marca.ID_Marca;
                    cboCategoria.SelectedValue = articulo.Categoria.ID_Categoria;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //private void txtImagen_Leave(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        //pbImagen.Load(txtImagen.Text);
        //    }
        //    catch (Exception)
        //    {
        //        pbImagen.Load("https://bub.bh/wp-content/uploads/2018/02/image-placeholder.jpg");
        //    }
        //}
        private void CargarImagen(string imagenes)
        {
            try
            {
                pbImagen.Load(imagenes);
            }
            catch (Exception)
            {
                pbImagen.Load("https://media.istockphoto.com/id/1128826884/es/vector/ning%C3%BAn-s%C3%ADmbolo-de-vector-de-imagen-falta-icono-disponible-no-hay-galer%C3%ADa-para-este-momento.jpg?s=612x612&w=0&k=20&c=9vnjI4XI3XQC0VHfuDePO7vNJE7WDM8uzQmZJ1SnQgk=");
            }
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            int max = articulo.Imagenes.Count;
            if (index == max - 1)
                MessageBox.Show("No hay mas imagenes que mostrar!");
            else
            {
                index++;
                CargarImagen(imagenes[index].Url);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (index == 0)
                index = 0;
            else
            {
                index--;
                CargarImagen(imagenes[index].Url);
            }
        }

        private void btnAgregarmas_Click(object sender, EventArgs e)
        {
            AgregarImagenesfrm ventanaImg = new AgregarImagenesfrm(articulo);
            ventanaImg.ShowDialog();
        }

        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            int max = imagenes.Count;
            if (index == max - 1)
                MessageBox.Show("No hay mas imagenes que mostrar!");
            else
            {
                index++;
                CargarImagen(imagenes[index].Url);
            }
        }

        private void btnAnterior_Click_1(object sender, EventArgs e)
        {
            if (index == 0)
                index = 0;
            else
            {
                index--;
                CargarImagen(imagenes[index].Url);
            }
        }

        private void txtURL_Leave(object sender, EventArgs e)
        {
            CargarImagen(txtURL.Text);
        }
    }
}
