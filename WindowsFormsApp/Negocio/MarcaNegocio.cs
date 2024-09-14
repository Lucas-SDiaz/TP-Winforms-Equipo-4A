using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class MarcaNegocio
    {

        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setQuery("SELECT Id, Descripcion FROM MARCAS");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.ID_Marca = datos.Lector.GetInt32(0);
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void agregar(Marca marca)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setQuery("INSERT INTO MARCAS (Descripcion) VALUES('" + marca.Descripcion + "');");
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
    }
}
