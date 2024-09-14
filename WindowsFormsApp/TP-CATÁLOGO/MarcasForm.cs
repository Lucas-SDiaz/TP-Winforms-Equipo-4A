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

        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            AgregarMarcaFrm ventanaAgregarMarca = new AgregarMarcaFrm();
            ventanaAgregarMarca.ShowDialog();
        }

        private void MarcasForm_Load(object sender, EventArgs e)
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
