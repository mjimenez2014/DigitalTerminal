using System;
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
        frmNewVenta pos;
        DocumentoModel documento;
        CafModel cafModel = new CafModel();
        FolioModel folioM = new FolioModel();

        public frmSelecVenta(frmNewVenta pos, DocumentoModel doc)
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
            Int32 idCafActual = cafModel.getCafActual(33);
            if(cafModel.getUltimoFolioCaf(idCafActual,33) == folioM.getUltimoFolio(idCafActual))
            {
                MessageBox.Show("No quedan Folios en el CAF, Comuniquese con:\n www.invoicedigital.cl", "Digital Terminal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
            
            this.pos.creaDte(33, idCafActual);
            this.Close();
            pos.btnSalir.PerformClick();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (documento.Referencia.Count != 0)
            {
                Int32 idCafActual = cafModel.getCafActual(61);
                if (cafModel.getUltimoFolioCaf(idCafActual, 61) == folioM.getUltimoFolio(idCafActual))
                {
                    MessageBox.Show("No quedan Folios en el CAF, Comuniquese con:\n  www.invoicedigital.cl", "Digital Terminal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    this.pos.creaDte(61, idCafActual);
                    this.Close();
                    pos.btnSalir.PerformClick();
                }
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
            this.pos.creaDte(56, cafModel.getCafActual(56));
            this.Close();
            pos.btnSalir.PerformClick();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Int32 idCafActual = cafModel.getCafActual(52);
            if (cafModel.getUltimoFolioCaf(idCafActual, 52) == folioM.getUltimoFolio(idCafActual))
            {
                MessageBox.Show("No quedan Folios en el CAF, Comuniquese con:\n www.invoicedigital.cl", "Digital Terminal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                this.pos.creaDte(52, idCafActual);
                this.Close();
                pos.btnSalir.PerformClick();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.pos.creaDte(46, cafModel.getCafActual(46));
            this.Close();
            pos.btnSalir.PerformClick();
        }

        private void btnFacExe_Click(object sender, EventArgs e)
        {
            this.pos.creaDte(34, cafModel.getCafActual(34));
            this.Close();
            pos.btnSalir.PerformClick();
        }
    }
}
