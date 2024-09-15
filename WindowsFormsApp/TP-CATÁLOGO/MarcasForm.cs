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
    public partial class MarcasForm : Form
    {
        private List<Marca> listaMarcas;

        MarcaNegocio negocio = new MarcaNegocio();

        public MarcasForm()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult answer = MessageBox.Show("Desea eliminar este registro?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    Marca selected = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                    negocio.eliminar(selected.ID_Marca);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cargar();
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            AgregarMarcaFrm ventanaAgregarMarca = new AgregarMarcaFrm();
            ventanaAgregarMarca.ShowDialog();
            cargar();
        }

        private void MarcasForm_Load(object sender, EventArgs e)
        {
            try
            {
                listaMarcas = negocio.listar();
                dgvMarcas.DataSource = listaMarcas;
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnModificarMarca_Click(object sender, EventArgs e)
        {
            {
                Marca selected = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                AgregarMarcaFrm editarMarca = new AgregarMarcaFrm(selected);
                editarMarca.ShowDialog();
                cargar();
            }

        }
        private void cargar()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                listaMarcas = negocio.listar();
                dgvMarcas.DataSource = listaMarcas;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
