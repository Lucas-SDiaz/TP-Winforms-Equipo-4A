﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CATÁLOGO
{
    public class Categoria
    {
        public int ID_Categoria { get; set; }
        public string Descripcion { get; set; }
        public Categoria() { }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
