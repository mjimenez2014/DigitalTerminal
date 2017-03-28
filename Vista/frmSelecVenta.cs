﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modelo;

namespace Vista
{
    public partial class frmSelecVenta : Form
    {
        frmPuntoVenta pos;
        DocumentoModel documento;
        public frmSelecVenta(frmPuntoVenta pos, DocumentoModel doc)
        {
            InitializeComponent();
            this.pos = pos;
            this.documento = doc;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmSelecVenta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            this.pos.creaDte(33,new CafModel().getCafActual(33));
            this.Close();
            pos.btnSalir.PerformClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (documento.Referencia.Count != 0)
            {
                this.pos.creaDte(61, new CafModel().getCafActual(61));
                this.Close();
                pos.btnSalir.PerformClick();
            }else
            {

                MessageBox.Show("Tiene que agregar el documento de referencia","Digital Terminal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.pos.creaDte(56, new CafModel().getCafActual(56));
            this.Close();
            pos.btnSalir.PerformClick();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.pos.creaDte(52, new CafModel().getCafActual(52));
            this.Close();
            pos.btnSalir.PerformClick();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.pos.creaDte(46, new CafModel().getCafActual(46));
            this.Close();
            pos.btnSalir.PerformClick();
        }
    }
}
