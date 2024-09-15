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
        private Marca marca = null;

        MarcaNegocio negocio = new MarcaNegocio();
        public AgregarMarcaFrm()
        {
            InitializeComponent();
        }
        public AgregarMarcaFrm(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if(marca == null)
                marca = new Marca();

            marca.Descripcion = txtNuevaMarca.Text;
            if(marca.ID_Marca != 0)
            {
                negocio.modificar(marca);
                MessageBox.Show("Marca modificada exitosamente!");
            }
            else
            {
                negocio.agregar(marca);
                MessageBox.Show("Marca agregada exitosamente!");
            }
                

            Close();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void AgregarMarcaFrm_Load(object sender, EventArgs e)
        {
            if(marca != null)
            {
                txtNuevaMarca.Text = marca.Descripcion;
            }
        }
    }
}
