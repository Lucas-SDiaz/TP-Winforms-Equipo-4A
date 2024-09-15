using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ImagenNegocio
    {
        public void agregar(Imagen ImgNueva)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setQuery("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @ImagenUrl)");
                datos.setParameters("@IdArticulo", ImgNueva.ID_Art);
                datos.setParameters("@ImagenUrl", ImgNueva.ID_Imagen);
                datos.ejecutarAccion();



            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public List<Imagen> listar()
        {
            List<Imagen> lista = new List<Imagen>();
            AccesoDatos datos = new AccesoDatos();


            try
            {
                datos.setQuery("select Id, IdArticulo, ImagenUrl from IMAGENES;");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Imagen aux = new Imagen();
                    aux.ID_Imagen = (int)datos.Lector["id"];
                    aux.ID_Art = (int)datos.Lector["IdArticulo"];
                    aux.Url = (string)datos.Lector["ImagenUrl"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}

