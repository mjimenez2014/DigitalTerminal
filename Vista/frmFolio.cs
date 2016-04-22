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
    public partial class frmFolio : Form
    {
        frmCaf frmcaf;
        Int32 idCafs;
        folioModel folioM = new folioModel();
        public frmFolio()
        {
            InitializeComponent();
        }
        public frmFolio(frmCaf frmcaf, Int32 idCaf)
        {
            InitializeComponent();
            this.frmcaf = frmcaf;
            idCafs = idCaf;
        }



        private void agregaFolios(int inicial, int final)
        {
            //TODO verificar si ya existen
            while(inicial < final+1)
            {
                //Console.WriteLine(inicial);
                folioM.folio = inicial;
                folioM.idcaf = Convert.ToInt32(labelIdCaf.Text);
                folioM.save(folioM);              
                inicial = inicial+1;
            }
  
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (folioM.exist(Convert.ToInt32(labelIdCaf.Text), Convert.ToInt32(textBoxInicial.Text)) == "False")
            {
                int inicial = Convert.ToInt32(textBoxInicial.Text);
                int final = Convert.ToInt32(textBoxFinal.Text);
                agregaFolios(inicial, final);
                MessageBox.Show("Se agregarón los folios: " + inicial + " Hasta: " + final + " con Exito!!!");
                actDataG();
            }
            else
            {
                MessageBox.Show("El folio: " + Convert.ToInt32(textBoxInicial.Text) + " Ya esta en el CAF");
            }

        }

        private void frmFolio_Load(object sender, EventArgs e)
        {
            actDataG();
            labelIdCaf.Text = idCafs.ToString(); ;
        }

        private void actDataG()
        {
            dataGridView1.Rows.Clear();
            DataTable dt = new folioModel().getFolioXId(idCafs);
            foreach (DataRow row in dt.Rows)
            {
                Int32 n = this.dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = row["idcaf"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = row["folio"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = row["estado"].ToString();

                //dataGridView1.Rows[n].Cells[5].Value = "  Edita  ";

            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxFinal_Validated(object sender, EventArgs e)
        {
            if(Convert.ToInt32(textBoxInicial.Text) > Convert.ToInt32(textBoxFinal.Text))
            {
                MessageBox.Show("El valor inicial no puede ser Mayor al Final");
                textBoxInicial.Text = "0";
                textBoxFinal.Text = "0";
                textBoxInicial.Select();
                textBoxInicial.SelectAll();
            }
        }
    }
}
