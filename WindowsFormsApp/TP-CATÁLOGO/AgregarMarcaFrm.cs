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
    public partial class AgregarMarcaFrm : Form
    {
        MarcaNegocio negocio = new MarcaNegocio();
        public AgregarMarcaFrm()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            Marca aux = new Marca();
            aux.Descripcion = txtNuevaMarca.Text;
            MessageBox.Show("Marca agregada exitosamente!");
            negocio.agregar(aux);
            Close();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
