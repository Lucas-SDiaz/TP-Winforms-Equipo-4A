using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace TP_CATÁLOGO
{
    internal class ArticuloNegocio
    {
        SqlConnection conexion = new SqlConnection();
        SqlCommand comando = new SqlCommand();
        SqlDataReader lector;
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            


            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true; ";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT A.Id ,Codigo, Nombre, A.Descripcion, M.Descripcion AS 'Marca', C.Descripcion AS 'Categoría', Precio FROM ARTICULOS A, MARCAS M , CATEGORIAS C where M.Id = A.IdMarca and A.IdCategoria = c.Id";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = lector.GetInt32(0);
                    aux.CodigoArticulo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)lector["Categoría"];
                    aux.Precio = lector.GetDecimal(6);

                    lista.Add(aux);
                }

            conexion.Close();
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
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true; ";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT id, IdArticulo, ImagenUrl FROM IMAGENES WHERE IdArticulo = " + art.Id;
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Imagen imagen = new Imagen();
                    imagen.ID_Imagen = lector.GetInt32(0);
                    imagen.ID_Art = lector.GetInt32(1);
                    imagen.Url = (string)lector["ImagenUrl"];
                 

                    lista.Add(imagen);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
