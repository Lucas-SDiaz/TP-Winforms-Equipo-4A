using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_CATÁLOGO
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            ArticulosForm ventanaArticulos = new ArticulosForm();
            ventanaArticulos.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            MarcasForm ventaMarcas = new MarcasForm();
            ventaMarcas.ShowDialog();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            CategoriasForm ventanaCategorias = new CategoriasForm();
            ventanaCategorias.ShowDialog();
        }
    }
}
