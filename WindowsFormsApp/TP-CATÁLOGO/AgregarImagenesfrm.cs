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
    public partial class AgregarImagenesfrm : Form
    {
        Articulo articulo = null;
        ArticuloNegocio negocio = new ArticuloNegocio();
        ImagenNegocio imgNegocio = new ImagenNegocio();    
        public AgregarImagenesfrm(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtURL.Text))
                {
                    int idArticulo = negocio.obtenerIdArticuloPorCodigo(articulo.CodigoArticulo);
                    imgNegocio.agregarImagen(idArticulo, txtURL.Text);
                }
                MessageBox.Show("Agregado correctamente");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Imagen erronea. reintente");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
