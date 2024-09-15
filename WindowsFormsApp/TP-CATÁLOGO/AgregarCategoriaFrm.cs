using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TP_CATÁLOGO
{
    public partial class AgregarCategoriaFrm : Form
    {
        private Categoria categoria = null;

        CategoriaNegocio negocio = new CategoriaNegocio();

        public AgregarCategoriaFrm()
        {
            InitializeComponent();
        }
        public AgregarCategoriaFrm(Categoria categoria, bool esModificacion = false)
        {
            InitializeComponent();
            this.categoria = categoria;

            if (esModificacion)
            {
                lblAgregueNuevaCat.Text = "Modificar categoría";
            }
            else
            {
                lblAgregueNuevaCat.Text = "Agregar categoría ";
            }
        }
       
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (categoria == null)
                categoria = new Categoria();

            categoria.Descripcion = txtAgregarCategoria.Text;
            if (categoria.ID_Categoria != 0)
            {
                negocio.modificar(categoria);
                MessageBox.Show("Categoria modificada exitosamente!");
            }
            else
            {
                negocio.agregar(categoria);
                MessageBox.Show("Categoria agregada exitosamente!");
            }


            Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AgregarCategoriaFrm_Load(object sender, EventArgs e)
        {
            if (categoria != null)
            {
                txtAgregarCategoria.Text = categoria.Descripcion;
            }
        }

    }

}
