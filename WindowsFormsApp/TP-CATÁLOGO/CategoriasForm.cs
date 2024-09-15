using Negocio;
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

namespace TP_CATÁLOGO
{
    public partial class CategoriasForm : Form
    {
        private List<Categoria> listaCategorias;

        CategoriaNegocio negocio = new CategoriaNegocio();

        public CategoriasForm()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarCategoría_Click(object sender, EventArgs e)
        {
            AgregarCategoriaFrm ventanaAgregarCat = new AgregarCategoriaFrm();
            ventanaAgregarCat.ShowDialog();
            cargar();
        }

        private void CategoriasForm_Load(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                listaCategorias = negocio.listar();
                dgvCategorias.DataSource = listaCategorias;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            {
                Categoria selected = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                AgregarCategoriaFrm editarCategoria = new AgregarCategoriaFrm(selected, true);
                editarCategoria.ShowDialog();
                cargar();
            }
        }
        private void cargar()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                listaCategorias = negocio.listar();
                dgvCategorias.DataSource = listaCategorias;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
           
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar esta categoría?", "Eliminado", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                
                if(respuesta == DialogResult.OK)
                {
                    Categoria selected = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                    negocio.eliminar(selected.ID_Categoria);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cargar();
        }
    }
}
