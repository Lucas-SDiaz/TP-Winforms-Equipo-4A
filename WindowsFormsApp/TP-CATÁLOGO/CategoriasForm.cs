﻿using System;
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
    public partial class CategoriasForm : Form
    {
        public CategoriasForm()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarCategoría_Click(object sender, EventArgs e)
        {
            AgregarCategoriaFrm ventanaAgregarCat = new AgregarCategoriaFrm();
            ventanaAgregarCat.ShowDialog();
        }
    }
}
