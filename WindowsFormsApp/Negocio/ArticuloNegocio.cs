using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        
        AccesoDatos datos = new AccesoDatos();
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            try
            {
                datos.setQuery("SELECT A.Id ,Codigo, Nombre, A.Descripcion, M.Descripcion AS 'Marca', C.Descripcion AS 'Categoría', Precio FROM ARTICULOS A, MARCAS M , CATEGORIAS C where M.Id = A.IdMarca and A.IdCategoria = c.Id");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = datos.Lector.GetInt32(0);
                    aux.CodigoArticulo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoría"];
                    aux.Precio = datos.Lector.GetDecimal(6);

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<Imagen> listaImagenesXArt(Articulo art)
        {
            List<Imagen> lista = new List<Imagen>();

            try
            {
                datos.setQuery("SELECT id, IdArticulo, ImagenUrl FROM IMAGENES WHERE IdArticulo = " + art.Id);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Imagen imagen = new Imagen();
                    imagen.ID_Imagen = datos.Lector.GetInt32(0);
                    imagen.ID_Art = datos.Lector.GetInt32(1);
                    imagen.Url = (string)datos.Lector["ImagenUrl"];


                    lista.Add(imagen);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

