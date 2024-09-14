using Dominio;
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


namespace TP_CATÁLOGO
{
    public partial class AgregarCategoriaFrm : Form
    {
        CategoriaNegocio negocio = new CategoriaNegocio();

        public AgregarCategoriaFrm()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Agregar categoría al listado
            Categoria aux = new Categoria();
            aux.Descripcion = txtAgregarCategoria.Text;
            MessageBox.Show("Categoría agregada exitosamente!");
            negocio.agregar(aux);
            Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
