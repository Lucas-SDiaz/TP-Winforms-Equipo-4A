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
    public partial class ArticulosForm : Form
    {
        private List<Articulo> listaArticulo;

        ArticuloNegocio negocio = new ArticuloNegocio();

        public ArticulosForm()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo selected;
            selected = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            List<Imagen> lista = new List<Imagen>();
            lista = negocio.listaImagenesXArt(selected);


            DetalleArticuloFrm ventanaDetalleArticulo = new DetalleArticuloFrm(selected, lista);
            ventanaDetalleArticulo.ShowDialog();
        }

        private void ArticulosForm_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulo = negocio.listar();
                dgvArticulos.DataSource = listaArticulo;
                //dgvArticulos.DataSource = negocio.listar();
                ocultarColumnas();
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }

            //Carga de los campos del desplegable para búsqueda avanzada.
            cboCampo.Items.Add("CodigoArticulo");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Categoría");

            //Validaciones de búsqueda avanzada
            //Deshabilito el botón de búsqueda al inicio
            btnBuscar.Enabled = false;

            cboCampo.SelectedIndexChanged += new EventHandler(ValidarCampos);
            cboCriterio.SelectedIndexChanged += new EventHandler(ValidarCampos);
        }

        private void ValidarCampos(object sender, EventArgs e)
        {
            //Habilito la búsqueda solo si ambos ComboBox tienen selección
            if (cboCampo.SelectedIndex != -1 && cboCriterio.SelectedIndex != -1 )
            {
                btnBuscar.Enabled = true;
            }
            else
            {
                btnBuscar.Enabled = false;
            }
        }

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["Precio"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Visible = false;
            dgvArticulos.Columns["Imagen"].Visible=false;
            
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        { 
            List<Articulo> listaFiltrada;
            string filtro = txtFiltro.Text;

            if (filtro != "")
            {
                listaFiltrada = listaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulo;
            }

                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = listaFiltrada;
                ocultarColumnas();   
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if (opcion == "CodigoArticulo")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Contiene ");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con ");
                cboCriterio.Items.Add("Termina con ");
                cboCriterio.Items.Add("Contiene ");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cboCampo.SelectedIndex == -1 || cboCriterio.SelectedIndex == -1)
            {
                MessageBox.Show("Debe completar todos los campos para realizar una búsqueda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ArticuloNegocio negocio = new ArticuloNegocio();
            string campo = cboCampo.SelectedItem.ToString();
            string criterio = cboCriterio.SelectedItem.ToString();
            string filtro = txtFiltroAvanzado.Text;
            dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar este artículo?", "Eliminado", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                if (respuesta == DialogResult.OK)
                {
                    Articulo selected = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                       
                    negocio.eliminar(selected.Id);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cargar();
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulo = negocio.listar();
                dgvArticulos.DataSource = listaArticulo;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAgregarArticulos_Click(object sender, EventArgs e)
        {
            FrmAgregarArticulo alta = new FrmAgregarArticulo();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            Articulo selected = new Articulo();
                
            selected = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            selected.Imagenes = new List<Imagen>();
            selected.Imagenes = negocio.listaImagenesXArt(selected);
            FrmAgregarArticulo editarArticulo = new FrmAgregarArticulo(selected);
            editarArticulo.ShowDialog();
            cargar();
        }
    }
}

