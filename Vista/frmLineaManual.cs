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
    public partial class frmLineaManual : Form
    {
        private frmNewVenta frmPos;
        ProductosModel producto = new ProductosModel();
        Detalle detalle = new Detalle();
        public frmLineaManual()
        {
            InitializeComponent();
        }

        public frmLineaManual(frmNewVenta frmPOS)
        {
            InitializeComponent();
            this.frmPos = frmPOS;

        }

        private void buttonAgrega_Click(object sender, EventArgs e)
        {
            Decimal dctoPrc = 0;
            int descuentoMontoBruto = 0;
            if (textBoxCantidad.Text != "" && txtNombre.Text != "" && txtPrecioUnitario.Text != "")
            {
                producto.codigoInt = "0";
                producto.nombre = this.txtNombre.Text;
                //si es exento no hacer nada
                producto.precioventa = Convert.ToInt32(decimal.Round(Convert.ToDecimal(labelPrecioBruto.Text), MidpointRounding.AwayFromZero));
                producto.precioNeto = Decimal.Round(Convert.ToDecimal(labelPrecioNeto.Text), 4);
                producto.unmditem = "C/U";
                if (checkBoxExento.Checked != true)
                {
                    producto.exento = "False";
                    detalle.IndExe = "0";
                }
                else
                {
                    producto.exento = "True";
                    producto.precioNeto = 0;
                    detalle.IndExe = "1";
                }

                detalle.QtyItem = Convert.ToDecimal(textBoxCantidad.Text);
                detalle.DscItem = textBoxDscItem.Text;

                if (textBoxDctoPrc.Text == "" || textBoxDctoPrc.Text == "0")
                {
                    dctoPrc = 1;
                }
                else
                {
                    dctoPrc = Convert.ToDecimal(textBoxDctoPrc.Text) / 100;
                    detalle.DescuentoPct = dctoPrc;
                    detalle.DescuentoMonto = Convert.ToInt32(Decimal.Round(Convert.ToDecimal(labelLineaNeto.Text) * dctoPrc, MidpointRounding.AwayFromZero));
                    descuentoMontoBruto = Convert.ToInt32(Decimal.Round(Convert.ToInt32(labelTotalLinea.Text) * dctoPrc, MidpointRounding.AwayFromZero));
                }

                detalle.MontoItem = Convert.ToInt32(Decimal.Round(Convert.ToDecimal(labelLineaNeto.Text)) - detalle.DescuentoMonto);
                detalle.MontoBruItem = Convert.ToInt32(Convert.ToDecimal(labelTotalLinea.Text)) - descuentoMontoBruto;
                detalle.DscItem = textBoxDscItem.Text;
                frmPos.AddProducto(producto, detalle);
                this.Close();
            }
            else
            {
                MessageBox.Show("Tiene que ingresar Los datos en blanco");
                textBoxCantidad.Select();
                textBoxCantidad.SelectAll();
                textBoxCantidad.TextAlign = HorizontalAlignment.Center;
                textBoxCantidad.BackColor = Color.GreenYellow;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLineaManual_Load(object sender, EventArgs e)
        {
            txtNombre.Select();
        }

        private void txtPrecioUnitario_TextChanged(object sender, EventArgs e)
        {

            actualizaMontos();
        }

        private void actualizaMontos()
        {
            if (textBoxCantidad.Text != "" && txtPrecioUnitario.Text != "")
            {
                if (checkBoxExento.Checked != true)
                {
                    if (checkBoxConImpuestos.Checked == false)
                    {
                        Double brutoUnitario = 0;
                        brutoUnitario = Convert.ToDouble(txtPrecioUnitario.Text) * 1.19;
                        labelPrecioBruto.Text = decimal.Round(Convert.ToDecimal(brutoUnitario.ToString()), 4).ToString();
                        labelPrecioNeto.Text = txtPrecioUnitario.Text;
                    }

                    if (checkBoxConImpuestos.Checked == true)
                    {
                        Double netoUnitario = 0;
                        netoUnitario = Convert.ToDouble(txtPrecioUnitario.Text) / 1.19;
                        labelPrecioNeto.Text = decimal.Round(Convert.ToDecimal(netoUnitario.ToString()), 4).ToString();
                        labelPrecioBruto.Text = txtPrecioUnitario.Text;
                    }
                }
                else
                {
                    labelPrecioNeto.Text = txtPrecioUnitario.Text;
                    labelPrecioBruto.Text = txtPrecioUnitario.Text;
                }



                if (System.Text.RegularExpressions.Regex.IsMatch(textBoxCantidad.Text, "[^0-9.]"))
                {
                    MessageBox.Show("solo se permiten numeros en la cantidad");
                    textBoxCantidad.Text = "";
                    textBoxCantidad.Select();
                }
                else
                {
                    if (textBoxCantidad.Text != "")
                    {

                        Decimal precioNeto = decimal.Round(Convert.ToDecimal(labelPrecioNeto.Text), 4);
                        Decimal precio = Convert.ToDecimal(txtPrecioUnitario.Text);
                        Decimal cantidad = Convert.ToDecimal(textBoxCantidad.Text);
                        labelTotalLinea.Text = "" + (cantidad * decimal.Round(precio, 0));
                        labelLineaNeto.Text = "" + (cantidad * precioNeto);
                    }
                }
            }
        }


        private void textBoxCantidad_TextChanged(object sender, EventArgs e)
        {

            actualizaMontos();

        }

        private void checkBoxConImpuestos_CheckedChanged(object sender, EventArgs e)
        {
            actualizaMontos();
        }

        private void checkBoxExento_CheckedChanged(object sender, EventArgs e)
        {
            actualizaMontos();
        }
    }
}
