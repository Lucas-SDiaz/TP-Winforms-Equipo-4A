using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace TP_CATÁLOGO
{
    public partial class DetalleArticuloFrm : Form
    {
        private Articulo articulo = null;
        private List<Imagen> imagenes = null;
        int index = 0;
         
        public DetalleArticuloFrm()
        {
            InitializeComponent();
        }
        public DetalleArticuloFrm(Articulo art, List<Imagen> lista)
        {
            InitializeComponent();
            this.articulo = art;
            imagenes = lista;
        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DetalleArticuloFrm_Load(object sender, EventArgs e)
        {
            lblMarca.Text =          "Marca: " + articulo.Marca;
            lblCategoria.Text =      "Categoría: " + articulo.Categoria;
            lblPrecio.Text =         "Precio:            $" + articulo.Precio;
            lblDescripcionArt.Text = "Descripción: " + articulo.Descripcion;
            lblNombre.Text =         "Nombre: " + articulo.Nombre;
            CargarImagen(imagenes[0].Url);
        }
        private void CargarImagen(string imagenes)
        {
            try
            {
                pbxImagenesArticulo.Load(imagenes);
            }
            catch(Exception)
            {
                pbxImagenesArticulo.Load("https://media.istockphoto.com/id/1128826884/es/vector/ning%C3%BAn-s%C3%ADmbolo-de-vector-de-imagen-falta-icono-disponible-no-hay-galer%C3%ADa-para-este-momento.jpg?s=612x612&w=0&k=20&c=9vnjI4XI3XQC0VHfuDePO7vNJE7WDM8uzQmZJ1SnQgk=");
            }

        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            int max = imagenes.Count;
            if (index == max - 1)
                MessageBox.Show("No hay mas imagenes que mostrar!");
            else
            {
                index ++;
                CargarImagen(imagenes[index].Url);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (index == 0)
                index = 0;
            else
            {
                index --;
                CargarImagen(imagenes[index].Url);
            }
        }
    }
}
