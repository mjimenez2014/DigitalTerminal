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
    public partial class frmListaProductos : Form
    {
        DataTable dataTable;
        public frmListaProductos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (textBoxBuscaXNo.Text == "")
            {
            }
            else
            {
                dataTable =  new ProductosModel().getProdXNombre(this.textBoxBuscaXNo.Text);
                foreach (DataRow fila in dataTable.Rows)
                {
                    Int32 n = this.dataGridView1.Rows.Add();

                    dataGridView1.Rows[n].Cells[0].Value = fila["id"].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = fila["codigoInt"].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = fila["nombre"].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = fila["precioNeto"].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = fila["precioVenta"].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = " MODIFICAR ";
                }

                this.dataGridView1.Select();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListaProductos_Load(object sender, EventArgs e)
        {
            textBoxBuscaXNo.Select();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Edita"].Index && e.RowIndex >= 0)
            {
                String idSistema = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
               // MessageBox.Show("Edita " + idSistema);
                new frmProductos(Convert.ToInt32(idSistema),this).ShowDialog();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            new frmProductos(0,this).ShowDialog();
        }

        private void textBoxBuscaXNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                buttonBuscar.PerformClick();
            }
        }

        private void textBoxBuscaXNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
