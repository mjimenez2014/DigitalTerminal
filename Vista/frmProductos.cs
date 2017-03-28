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
    public partial class frmProductos : Form
    {
        MetodosComunes metodoscomunes = new MetodosComunes();
        frmListaProductos frmlistaproduc;
        Int32 idProd;
        DataTable dataTable;
        public frmProductos()
        {
            InitializeComponent();
        }
        public frmProductos(Int32 idProd, frmListaProductos frmlistaproduc)
        {
            InitializeComponent();
            this.idProd = idProd;
            this.frmlistaproduc = frmlistaproduc;
        }


        private string validaForm()
        {
            string validate = "true";
            if (textBoxNombre.Text == "") validate = "false";
            if (textBoxCodInt.Text == "") validate = "false";
            if (textBoxPrecioBruto.Text == "0") validate = "false";
            if (textBoxPrecioNeto.Text == "0") validate = "false";
            return validate;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (validaForm() == "true")
            {
                try
                {
                    ProductosModel producto = new ProductosModel();
                    producto.nombre = textBoxNombre.Text;// ToUpper();
                    producto.codigoInt = textBoxCodInt.Text;
                    producto.precioNeto = Convert.ToDecimal(textBoxPrecioNeto.Text);
                    producto.precioventa = Convert.ToInt32(textBoxPrecioBruto.Text);
                    producto.exento = checkBoxExento.Checked.ToString();
                    producto.save(producto);
                    this.frmlistaproduc.textBoxBuscaXNo.Text = textBoxNombre.Text;//.ToUpper();
                    this.frmlistaproduc.buttonBuscar.PerformClick();
                    MessageBox.Show(" El Producto se Guardo con Exito", "Digital Terminal", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);                   
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al Guardar: " + ex, "Digital Terminal", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }




        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
           
            if (idProd > 0)
            {
                buttonGuardar.Visible = false;
                buttonModifica.Visible = true;
                labelIdSistema.Visible = true;
                label6.Visible = true;
                
                dataTable = new ProductosModel().getProdXCodSistema(idProd);
                foreach (DataRow fila in dataTable.Rows)
                {
                    labelIdSistema.Text = fila["id"].ToString();
                    textBoxNombre.Text = fila["nombre"].ToString();
                    textBoxCodInt.Text = fila["codigoInt"].ToString();
                    textBoxPrecioNeto.Text = fila["precioNeto"].ToString();
                    textBoxPrecioBruto.Text = fila["precioVenta"].ToString();
                }
            }
        }

        private void buttonCalcula_Click(object sender, EventArgs e)
        {
            Double neto = Convert.ToDouble(textBoxPrecioNeto.Text);
            Double bruto = Convert.ToInt32(textBoxPrecioBruto.Text);

            if (textBoxPrecioBruto.Text == "0")
            {
                bruto = (neto * 1.19);
                Decimal  brutoDecimal =  Convert.ToDecimal(bruto);
                Decimal brutoRound = Decimal.Round(brutoDecimal);
                textBoxPrecioBruto.Text = brutoRound.ToString(); 
            }

            if (textBoxPrecioNeto.Text == "0")
            {
                neto = (bruto / 1.19);
                Decimal netoDecimal = Convert.ToDecimal(neto);
                Decimal netoRound = Decimal.Round(netoDecimal,4);
                textBoxPrecioNeto.Text = netoRound.ToString();
            }
        }

        private void buttonModifica_Click(object sender, EventArgs e)
        {
            ProductosModel producto = new ProductosModel();
            producto.id = Convert.ToInt32(labelIdSistema.Text);
            producto.nombre = textBoxNombre.Text;// ToUpper();
            producto.codigoInt = textBoxCodInt.Text;
            producto.precioNeto =  Convert.ToDecimal(textBoxPrecioNeto.Text);
            producto.precioventa = Convert.ToInt32( textBoxPrecioBruto.Text);
            producto.exento = checkBoxExento.Checked.ToString();
            try
            {
                producto.update(producto);
                this.frmlistaproduc.textBoxBuscaXNo.Text = textBoxNombre.Text;//.ToUpper();
                this.frmlistaproduc.buttonBuscar.PerformClick();
                this.frmlistaproduc.textBoxBuscaXNo.Select();
                this.frmlistaproduc.textBoxBuscaXNo.SelectAll();
                MessageBox.Show("El Productos "+producto.nombre + " se actualizó con éxito", "Digital Terminal", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en buttonModifica_Click" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
