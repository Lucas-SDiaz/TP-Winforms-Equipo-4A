using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CATÁLOGO
{
    public class Marca
    {
        public int ID_Marca { get; set; }
        public string Descripcion { get; set; }
        public Marca() { }
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
