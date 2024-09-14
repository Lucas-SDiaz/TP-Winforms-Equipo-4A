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
        }

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["Precio"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Visible = false;
            
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
    }
}

