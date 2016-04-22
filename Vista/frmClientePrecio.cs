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
    public partial class frmClientePrecio : Form
    {
        frmContribuyente frmCli;
        DataTable dataTable;
        public frmClientePrecio()
        {
            InitializeComponent();
        }
        public frmClientePrecio(frmContribuyente frmCli)
        {
            InitializeComponent();
            this.frmCli = frmCli;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtRut_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.dataGridView1.DataSource = new ClienteProductoModel().getProdClient(labelRutCli.Text);
            }
               
        }

        public void actulizaDataGrid()
        {
            dataGridView1.Rows.Clear();
            labelRutCli.Text = frmCli.textBoxRutCliente.Text;
            labelRznCli.Text = frmCli.textBoxRazonSocial.Text;
            dataTable = new ClienteProductoModel().getProdClient(labelRutCli.Text);


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


        private void frmClientePrecio_Load(object sender, EventArgs e)
        {
            actulizaDataGrid();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAgrega_Click(object sender, EventArgs e)
        {
            new frmClienteProducto(this).ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["modifica"].Index && e.RowIndex >= 0)
            {
                Int32 idSistema = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
                String rut = labelRutCli.Text;

               // MessageBox.Show("Edita " + idSistema +" Rut: "+ rut);
                new frmClienteProducto(this,rut, idSistema).ShowDialog();

            }
        }

        
    }
}
