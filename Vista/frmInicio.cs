using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmInicio : Form
    {
        frmVentas frmventas = new frmVentas();
        frmArchivosMaestros frmarchivosmaestros = new frmArchivosMaestros();
        frmListaCompras frmcompras = new frmListaCompras();
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmventas.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            frmarchivosmaestros.ShowDialog();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            frmcompras.ShowDialog();
        }
    }
}
