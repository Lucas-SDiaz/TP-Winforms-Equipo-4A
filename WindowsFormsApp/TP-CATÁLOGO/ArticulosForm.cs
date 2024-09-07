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
    public partial class ArticulosForm : Form
    {
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
            DetalleArticuloFrm ventanaDetalleArticulo = new DetalleArticuloFrm();
            ventanaDetalleArticulo.ShowDialog();
        }

        private void ArticulosForm_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio  = new ArticuloNegocio();
            dgvArticulos.DataSource = negocio.listar();
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["Precio"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Visible=false;

        }
    }
}
