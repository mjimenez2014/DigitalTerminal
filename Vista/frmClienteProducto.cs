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
    public partial class frmClienteProducto : Form
    {
        frmClientePrecio frmclienteprecio;
        ClienteProductoModel cliProdModel = new ClienteProductoModel();
        string rutCliente;
        Int32 idProd;
        
        public frmClienteProducto()
        {
            InitializeComponent();
        }
        public frmClienteProducto(frmClientePrecio frmclienteprecio)
        {
            InitializeComponent();
            this.frmclienteprecio = frmclienteprecio;
        }
        public frmClienteProducto(frmClientePrecio frmclienteprecio, string rutCliente, Int32 idProd)
        {
            InitializeComponent();
            this.rutCliente = rutCliente;
            this.idProd = idProd;
            this.frmclienteprecio = frmclienteprecio;
        }


        private void frmClienteProducto_Load(object sender, EventArgs e)
        {

                labelRznSocCli.Text = frmclienteprecio.labelRznCli.Text;
                buttonUpdate.Visible = true;
                dataGridView1.DataSource = new ClienteProductoModel().getProdClientXCod(rutCliente, idProd);
                dataGridView1.Select();
                if (textBoxNomProd.Text != "")
                {
                    btnSave.Visible = false;
                }
                else
                {
                    buttonUpdate.Visible = false;
                    textBoxNomProd.Select();
                }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }

        private void textBoxCodIntProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.dataGridView1.DataSource = new ProductosModel().getProdXCod(this.textBoxCodIntProd.Text);



                if (dataGridView1.RowCount != 0)
                {
                    this.dataGridView1.Select();
                }
                else
                {
                    MessageBox.Show("No se encuentra el producto");
                    this.textBoxCodIntProd.Select();
                    this.textBoxCodIntProd.SelectAll();
                }
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.textBoxCodIntProd.Text = (String)this.dataGridView1.CurrentRow.Cells["codigoInt"].Value;
            this.textBoxNomProd.Text = (String)this.dataGridView1.CurrentRow.Cells["nombre"].Value;
            this.labelIdProducto.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["id"].Value);

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (int)13)
            {
                e.Handled = true;
                textBoxPrcNeto.Select();
                textBoxPrcNeto.TextAlign = HorizontalAlignment.Center;
                textBoxPrcNeto.BackColor = Color.GreenYellow;
                textBoxprcVenta.TextAlign = HorizontalAlignment.Center;
                textBoxprcVenta.BackColor = Color.GreenYellow;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBoxPrcNeto.Text == "")
            {
                textBoxPrcNeto.Select();
                textBoxPrcNeto.SelectAll();
            }

            else
            {
                if (textBoxprcVenta.Text == "")
                {
                    textBoxprcVenta.Select();
                    textBoxprcVenta.SelectAll();
                }
                else
                {

                    if (cliProdModel.searchProdxCliente(Convert.ToInt32(labelIdProducto.Text), frmclienteprecio.labelRutCli.Text) == "false")
                    {
                        cliProdModel.idProducto = Convert.ToInt32(labelIdProducto.Text);
                        cliProdModel.rutCliente = frmclienteprecio.labelRutCli.Text.ToUpper();
                        cliProdModel.precioNeto = Convert.ToDecimal(textBoxPrcNeto.Text);
                        cliProdModel.precioVenta = Convert.ToInt32(textBoxprcVenta.Text);
                        cliProdModel.save(cliProdModel);
                        MessageBox.Show("El precio se agrego al cliente");
                        this.Close();
                        frmclienteprecio.actulizaDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("El Producto ya esta asignado al cliente");
                    }

                }


            }


        }

        private void textBoxNomProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.dataGridView1.DataSource = new ProductosModel().getProdXNombre(this.textBoxNomProd.Text.ToUpper());



                if (dataGridView1.RowCount != 0)
                {
                    this.dataGridView1.Select();
                }
                else
                {
                    MessageBox.Show("No se encuentra el producto");
                    this.textBoxNomProd.Select();
                    this.textBoxNomProd.SelectAll();
                }
            }
        }

        private void buttonCalcula_Click(object sender, EventArgs e)
        {
            Double neto = Convert.ToInt32(textBoxPrcNeto.Text);
            Double bruto = Convert.ToInt32(textBoxprcVenta.Text);

            if (textBoxprcVenta.Text == "0")
            {
                bruto = (neto * 1.19);
                Decimal brutoDecimal = Convert.ToDecimal(bruto);
                Decimal brutoRound = Decimal.Round(brutoDecimal);
                textBoxprcVenta.Text = brutoRound.ToString();
            }

            if (textBoxPrcNeto.Text == "0")
            {
                neto = (bruto / 1.19);
                Decimal netoDecimal = Convert.ToDecimal(neto);
                Decimal netoRound = Decimal.Round(netoDecimal,4);
                textBoxPrcNeto.Text = netoRound.ToString();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            ClienteProductoModel cliProdModel = new ClienteProductoModel();
            cliProdModel.rutCliente = frmclienteprecio.labelRutCli.Text.ToUpper();
            cliProdModel.idProducto = Convert.ToInt32(labelIdProducto.Text);
            cliProdModel.precioNeto = Convert.ToDecimal(textBoxPrcNeto.Text);
            cliProdModel.precioVenta = Convert.ToInt32(textBoxprcVenta.Text);

            try
            {
                cliProdModel.update(cliProdModel);
                MessageBox.Show("El Productos " + textBoxNomProd.Text + " se actualizó con éxito");
                frmclienteprecio.actulizaDataGrid();
                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en buttonUpdate" + ex.Message);
            }
        }
    }
}
