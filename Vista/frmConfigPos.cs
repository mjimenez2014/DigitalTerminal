using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modelo;
using Microsoft.Win32;

namespace Vista
{
    public partial class frmConfigPos : Form
    {
        RegistroWin regWin = new RegistroWin();

        public frmConfigPos()
        {
            InitializeComponent();
            regWin = regWin.getRegWin();
        }

        private void button1_Click(object sender, EventArgs e)
        {

             
        }

        private void frmConfigPos_Load(object sender, EventArgs e)
        {
            labelRutaPrint.Text = regWin.getRegWin().rutaPrint;
           
        }

        private void buttonAcepta_Click(object sender, EventArgs e)
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\DigitalTerminal\Config", "rutaPrint", labelRutaPrint.Text);
            MessageBox.Show("Los Registros se actualizarón con exito!","Digital Terminal", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void buttonBuscaRuta_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            labelRutaPrint.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnConfigPosSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
