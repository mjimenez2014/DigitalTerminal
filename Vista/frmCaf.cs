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
    public partial class frmCaf : Form
    {
        CafModel caf = new CafModel();
        public frmCaf()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog1.FileName.ToString();
            caf =  caf.xmlToCaf(openFileDialog1.FileName.ToString());
            labelRutEmpresa.Text   =  caf.rutEmpresa;
            labelFchCaf.Text = caf.fecha.ToString("yyyy-MM-dd");
            labelFolioIni.Text = caf.folioInicial.ToString();
            labelFolioFinal.Text = caf.folioFinal.ToString();
            labelTipoDte.Text = caf.tipoDte;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void frmCaf_Load(object sender, EventArgs e)
        {
            actDataG();
            dataGridView1.Select();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //verificar si ya existe
            if (caf.exist(openFileDialog1.SafeFileName) == "False")
            {
                if (caf.tipoDte != null)
                {
                    //
                    this.caf.nomXml = openFileDialog1.SafeFileName;
                    this.caf.save(caf);
                    actDataG();
                }
                else
                {
                    MessageBox.Show("Tiene que buscar el XML antes de guardar");
                }

            }
            else
            {
                MessageBox.Show("El CAF ya existe!!!");
            }
        }

        public void actDataG()
        {
            dataGridView1.Rows.Clear();
            DataTable dt = new CafModel().getCafs();

            foreach(DataRow row in dt.Rows)
            {
                Int32 n = this.dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = row["id"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = row["rutEmpresa"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = row["tipoDte"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = row["folioInicial"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = row["folioFinal"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = Convert.ToDateTime(row["fecha"].ToString()).ToString("yyyy-MM-dd");
                dataGridView1.Rows[n].Cells[6].Value = "  Edita  ";

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Edita"].Index && e.RowIndex >= 0)
            {
                int idSistema = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                //MessageBox.Show("Edita " + idSistema);
                new frmFolio(this, idSistema).ShowDialog();
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.labelRutEmpresa.Text = (String)this.dataGridView1.CurrentRow.Cells["rutEmpresa"].Value;
            this.labelFchCaf.Text = (String)this.dataGridView1.CurrentRow.Cells["fecha"].Value;
            this.labelFolioIni.Text = (String)this.dataGridView1.CurrentRow.Cells["folioInicial"].Value;
            this.labelFolioFinal.Text = (String)this.dataGridView1.CurrentRow.Cells["folioFinal"].Value;
            this.labelTipoDte.Text = (String)this.dataGridView1.CurrentRow.Cells["tipoDte"].Value;

        }
    }
}
