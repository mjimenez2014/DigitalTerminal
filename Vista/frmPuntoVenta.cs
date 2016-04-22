﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modelo;
using System.Globalization;

namespace Vista
{
    public partial class frmPuntoVenta : Form
    {
        int n = 0;
        ContribuyenteModel cliente= new ContribuyenteModel();
        DataTable dataTableCliente = new DataTable();
        DocumentoModel documento = new DocumentoModel();
        Detalle detalle = new Detalle();
        ReferenciaDoc referencia = new ReferenciaDoc();
        folioModel folio = new folioModel();
        DscRcgGlobal descuentoGlobal = new DscRcgGlobal();
        List<DscRcgGlobal> descuentosGlobales = new List<DscRcgGlobal>();
        frmInicio frminicio;
        
        public frmPuntoVenta()
        {
            InitializeComponent();
            
        }

        public frmPuntoVenta(frmInicio frminicio)
        {
            InitializeComponent();
            this.frminicio = frminicio;
        }
        public frmPuntoVenta(DocumentoModel doc, frmInicio frminicio)
        {
            InitializeComponent();
            this.documento = doc;
            this.frminicio = frminicio;
        }

        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            new frmBuscaCliente(this).ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscaProducto_Click(object sender, EventArgs e)
        {
            new frmBuscaProductos(this).ShowDialog();         
        }

        public DataGridView getDGVDetalle()
        {
            return this.dtgwDetalle;
        }


        private void frmPuntoVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {

                MessageBox.Show("F1");
            }
            if (e.KeyData == Keys.F7)
            {
                new frmBuscaProductos(this).ShowDialog();             
            }

            if (e.KeyData == Keys.F9)
            {
                MessageBox.Show("Agrega cliente");
            }
        }

        private void btnGeneraDoc_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frminicio.actualizaDG();
            this.Close();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            this.textBoxCodBarra.Select();
            frmBuscaProductos frmbuscaprod = new frmBuscaProductos(this);
            frmbuscaprod.ShowDialog();
        }

     public void frmPuntoVenta_Load(object sender, EventArgs e)
        {
            this.textBoxRutRecep.Select();
        }



     private void dtgwDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
     {
         try
         {
            
            decimal num1 = Convert.ToDecimal(this.dtgwDetalle.CurrentRow.Cells["precio"].Value);
            int num2 = Convert.ToInt32(this.dtgwDetalle.CurrentRow.Cells["cantidad"].Value) ;
            this.dtgwDetalle.CurrentRow.Cells["total"].Value = num1 * num2;
         }
             
         catch (Exception ex)
         {
             Console.WriteLine("" + ex);
         }
     }

     public void textBoxRut_KeyPress(object sender, KeyPressEventArgs e)
     {
         if (e.KeyChar == (int)13)
         {
             if (textBoxRutRecep.Text != "")
             {
                 textBoxRutRecep.Text = new MetodosComunes().formatearRut(textBoxRutRecep.Text);
                 dataTableCliente = cliente.getContribuyente(textBoxRutRecep.Text);
                 if (dataTableCliente.Rows.Count != 0)
                 {
                     labelRznSocRecep.Text = dataTableCliente.Rows[0][1].ToString();
                     labelGiroRecep.Text = dataTableCliente.Rows[0][2].ToString();
                     labelDireccionRecep.Text = dataTableCliente.Rows[0][3].ToString();
                     labelCiudadRecep.Text = dataTableCliente.Rows[0][8].ToString();
                     labelComunaRecep.Text = dataTableCliente.Rows[0][11].ToString();              
                     labelTelefonoRecep.Text = dataTableCliente.Rows[0][6].ToString();
                     textBoxRutRecep.Enabled = false;
                     textBoxCodBarra.Select();
                 }
                 else
                 {
                     MessageBox.Show("No esta Registrado el cliente");
                     textBoxRutRecep.Text = "";
                     // TODO verificar rut
                 }
             }
         }

}

     private void textBoxRut_KeyDown(object sender, KeyEventArgs e)
     {

     }

     private void textBoxRut_Validated(object sender, EventArgs e)
     {
         textBoxRutRecep.Text = new MetodosComunes().formatearRut(textBoxRutRecep.Text.ToUpper());
     }


     private void buttonBuscaCliente_Click(object sender, EventArgs e)
     {
         textBoxCodBarra.Select();
         new frmBuscaCliente(this).ShowDialog(); 
    
     }

     private void textBoxRut_TextChanged(object sender, EventArgs e)
     {

     }



     public void AddProducto(ProductosModel producto, Detalle detalle)
     {
         n = this.dtgwDetalle.Rows.Add();
         this.dtgwDetalle.Rows[n].Cells["elimina"].Value = "-";
         this.dtgwDetalle.Rows[n].Cells["item"].Value = n + 1;
         this.dtgwDetalle.Rows[n].Cells[2].Value =  producto.codigoInt.ToString(); 
         this.dtgwDetalle.Rows[n].Cells[3].Value =  producto.nombre.ToString();
         this.dtgwDetalle.Rows[n].Cells[4].Value =  producto.precioNeto.ToString();
         this.dtgwDetalle.Rows[n].Cells[5].Value =  producto.precioventa.ToString("N0", CultureInfo.CreateSpecificCulture("es-ES"));
         this.dtgwDetalle.Rows[n].Cells[6].Value =  detalle.QtyItem.ToString();
         this.dtgwDetalle.Rows[n].Cells[7].Value =  Decimal.Round(detalle.DescuentoPct*100);
         this.dtgwDetalle.Rows[n].Cells[8].Value = detalle.DescuentoMonto.ToString("N0", CultureInfo.CreateSpecificCulture("es-ES"));
         this.dtgwDetalle.Rows[n].Cells[9].Value =  detalle.MontoItem.ToString("N0", CultureInfo.CreateSpecificCulture("es-ES"));
         this.dtgwDetalle.Rows[n].Cells[10].Value = detalle.MontoBruItem.ToString("N0", CultureInfo.CreateSpecificCulture("es-ES"));
         this.dtgwDetalle.Rows[n].Cells[11].Value = producto.exento.ToString();
         this.dtgwDetalle.Rows[n].Cells[12].Value = detalle.DscItem.ToString();

         if (producto.exento == "False")
         {
             actualizaTotal();
             actualizaDescuentos();
         }
         else
         {
             this.dtgwDetalle.Rows[n].Cells[4].Value = 0;
             this.dtgwDetalle.Rows[n].Cells[9].Value = 0;
             actualizaExento();
         }


     }



     private void dtgwDetalle_Validated(object sender, EventArgs e)
     {
         //actualizaTotal();
     }

     private void actualizaTotal()
     {
         Decimal suma = 0;
         for (int i = 0; i < dtgwDetalle.RowCount; i++)
         {
                 suma += Convert.ToDecimal(this.dtgwDetalle.Rows[i].Cells[9].Value.ToString().Replace(".", ""));            
         }
         labelSubTotal.Text = suma.ToString("N0", CultureInfo.CreateSpecificCulture("es-ES"));
         calculaIva();
     }


     private void actualizaExento()
     {

         Decimal suma = 0;
         for (int i = 0; i < dtgwDetalle.RowCount; i++)
         {
             if (this.dtgwDetalle.Rows[i].Cells[4].Value.ToString() == "0")
             {
                 suma += Convert.ToDecimal(this.dtgwDetalle.Rows[i].Cells[10].Value.ToString().Replace(".", ""));
             }
         }
         labelMtoExento.Text = suma.ToString("N0", CultureInfo.CreateSpecificCulture("es-ES"));
         actualizaDescuentos();
        
     }
        private void calculaIva()
        {
            string subtotal = labelSubTotal.Text.Replace(".", "");
            Int32 exento = Convert.ToInt32(labelMtoExento.Text.Replace(".",""));
            labelIva.Text = (Convert.ToDecimal(subtotal) * Convert.ToDecimal(0.19)).ToString("N0", CultureInfo.CreateSpecificCulture("es-ES"));
            labelMtoTotal.Text = (Convert.ToInt32(subtotal) + exento + Convert.ToInt32(labelIva.Text.Replace(".", ""))).ToString("N0", CultureInfo.CreateSpecificCulture("es-ES")); 
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                documento.serialize(cargaDocumento(802,0));
                documento.save(documento); //TEST
                detalle.save(documento);
                referencia.save(documento);
                MessageBox.Show("El Pedido se guardo con Folio: " + documento.Folio);
                btnSalir.PerformClick();
            }
            catch(Exception err)
            {
                MessageBox.Show("" + err);
            }
        }


        public void creaDte(int tipo, int codCaf)
        {
            try
            {
                if (tipo == 52)
                {
                    new frmTipoTraslado(documento).ShowDialog();
                    documento.TasaIVA = 0;
                }
                documento.serialize(cargaDocumento(tipo, codCaf));
                // INSERT BD
                documento.save(documento); //TEST
                detalle.save(documento);
                referencia.save(documento);
                folio.modificaEstado("JSON CREADO", documento.Folio, codCaf);
                MessageBox.Show("El Documento Con folio: "+ documento.Folio+" se guardo");


            }
            catch (Exception err)
            {
                MessageBox.Show("" + err);
                folio.modificaEstado("DISPONIBLE", documento.Folio, codCaf);
            }
        }

        private string buscaTipoDte46(List<ReferenciaDoc> referencias)
        {
            string tipoDTE = string.Empty;
            foreach (var row in referencias)
            {
                if (row.TpoDocRef == "46")
                {
                    tipoDTE = "46";
                }

            }

            return tipoDTE;
        }

        private DocumentoModel cargaDocumento(int tipo, int codCAf)
        {
            string tipoDte = string.Empty;
            if (documento.estadoDte46 == "True") tipoDte = "46";
            try
            {
                EmpresaModel empresa = new EmpresaModel();
                empresa.getEmpresa();

                documento.TipoDTE = tipo; // cod pedido TODO
                if (tipo == 802)
                {
                    documento.Folio = folio.getUltimoFolioPedido();
                }
                else
                {
                    documento.Folio = folio.getUltimoFolio(codCAf);
                }
                // Cargo Datos Emisor
                documento.RUTEmisor = empresa.Rut;
                documento.RznSoc = empresa.RazonSocial;
                documento.GiroEmis = empresa.GiroEmisor;
                documento.CdgSIISucur = empresa.CodigoSiiSucursal;
                documento.Telefono = empresa.Telefono;
                documento.CorreoEmisor = empresa.Correo;
                documento.Acteco = empresa.Acteco;
                documento.DirOrigen = empresa.DireccionOrigen;
                documento.CmnaOrigen = empresa.ComunaOrigen;
                documento.CiudadOrigen = empresa.CiudadOrigen;
                // Datos Receptor
                documento.RUTRecep = this.textBoxRutRecep.Text;
                documento.RznSocRecep = this.labelRznSocRecep.Text;
                documento.GiroRecep = this.labelGiroRecep.Text;
                documento.DirRecep = this.labelDireccionRecep.Text;
                documento.CmnaRecep = this.labelComunaRecep.Text;
                documento.CiudadRecep = this.labelCiudadRecep.Text;
                documento.TelRecep = this.labelTelefonoRecep.Text;
                documento.FchEmis = Convert.ToDateTime((dateTimePickerFchEmis.Value)).ToString("yyyy-MM-dd"); //DateTime.Today.ToString("yyyy-MM-dd");  
                documento.NroOrdenCompra = textBoxOC.Text;
                documento.NroCita = textBoxCita.Text;
                documento.Sello = textBoxSello.Text;
                List<Detalle> detalles = new List<Detalle>();
                //cargo detalle doc
                for (int i = 0; i < dtgwDetalle.RowCount; i++)
                {
                    Detalle detalle = new Detalle();
                    detalle.NroLinDet = Convert.ToInt32(this.dtgwDetalle.Rows[i].Cells[1].Value);
                    detalle.TpoCodigo = "PLU";
                    detalle.VlrCodigo = this.dtgwDetalle.Rows[i].Cells[2].Value.ToString();
                    detalle.NmbItem = this.dtgwDetalle.Rows[i].Cells[3].Value.ToString();
                    detalle.PrcItem = Convert.ToDecimal(this.dtgwDetalle.Rows[i].Cells[4].Value.ToString());
                    detalle.PrcBruItem = Convert.ToDecimal(this.dtgwDetalle.Rows[i].Cells[5].Value.ToString().Replace(".", ""));
                    detalle.QtyItem = Convert.ToDecimal(this.dtgwDetalle.Rows[i].Cells[6].Value);
                    detalle.DescuentoPct = Convert.ToInt32(this.dtgwDetalle.Rows[i].Cells[7].Value);
                    detalle.DescuentoMonto = Convert.ToInt32(this.dtgwDetalle.Rows[i].Cells[8].Value.ToString().Replace(".", ""));
                    detalle.DescuentoBruMonto = Convert.ToInt32(Convert.ToDouble(this.dtgwDetalle.Rows[i].Cells[8].Value.ToString().Replace(".", "")) * 1.19);
                    detalle.MontoItem = Convert.ToInt32(this.dtgwDetalle.Rows[i].Cells[9].Value.ToString().Replace(".",""));
                    detalle.MontoBruItem = Convert.ToInt32(this.dtgwDetalle.Rows[i].Cells[10].Value.ToString().Replace(".", ""));
                    if (documento.TipoDTE == 46 || tipoDte == "46") detalle.CodImpAdic = "15";// Factura Electronica de compra
                    if (this.dtgwDetalle.Rows[i].Cells[11].Value.ToString() == "True")
                    {
                        detalle.IndExe = "1";
                        detalle.MontoItem = Convert.ToInt32(this.dtgwDetalle.Rows[i].Cells[10].Value.ToString().Replace(".", ""));
                        detalle.PrcItem = Convert.ToDecimal(this.dtgwDetalle.Rows[i].Cells[5].Value.ToString().Replace(".", ""));
                    }
                    detalle.DscItem = this.dtgwDetalle.Rows[i].Cells["DscItem"].Value.ToString();
                    detalles.Add(detalle);
                }
                //Cargo los descuentos globales
                if (textBoxDctoGlobal.Text != "0" )//|| textBoxDctoGlobal.Text != "")
                {
                    descuentoGlobal.NroLinDR = 1;
                    descuentoGlobal.TpoMov = "D";
                    descuentoGlobal.GlosaDR = "";
                    descuentoGlobal.TpoValor = "%";
                    descuentoGlobal.ValorDR = Convert.ToDecimal(textBoxDctoGlobal.Text);
                    descuentoGlobal.IndExeDR = 0;
                }
                else
                {
                    descuentoGlobal.NroLinDR = 0;
                    descuentoGlobal.TpoMov = "";
                    descuentoGlobal.GlosaDR = "";
                    descuentoGlobal.TpoValor = "";
                    descuentoGlobal.ValorDR = 0;
                    descuentoGlobal.IndExeDR = 0;
                }
                descuentosGlobales.Add(descuentoGlobal);
                documento.detalle = detalles;
                documento.TasaIVA = 19;
                documento.MntExe = Convert.ToInt32(labelMtoExento.Text.ToString().Replace(".", ""));
                documento.dscRcgGlobal = descuentosGlobales;
                documento.MntNeto = Convert.ToInt32(labelSubTotal.Text.ToString().Replace(".", ""));
                documento.IVA = Convert.ToInt32(labelIva.Text.ToString().Replace(".", ""));
                // Impuestos adicionales
                if (documento.TipoDTE == 46 || tipoDte == "46")
                {
                    ImptoReten impReten = new ImptoReten();
                    List<ImptoReten> imptoRetenes = new List<ImptoReten>();
                    impReten.TipoImp = "15";
                    impReten.TasaImp = 19;
                    impReten.MontoImp = Convert.ToInt32(labelIva.Text.ToString().Replace(".", ""));
                    imptoRetenes.Add(impReten);
                    documento.imptoReten = imptoRetenes;
                }
                else
                {
                    if (documento.imptoReten != null)
                    {
                        foreach (var impAdic in documento.imptoReten)
                        {
                            impAdic.TipoImp = "";
                            impAdic.TasaImp = 0;
                            impAdic.MontoImp = 0;
                        }
                    }
                }
                documento.MntTotal = Convert.ToInt32(labelMtoTotal.Text.ToString().Replace(".", ""));
                if (documento.TipoDTE == 46 || tipoDte == "46") documento.MntTotal = documento.MntNeto;
                return documento;
            }
            catch(Exception e)
            {

                MessageBox.Show("Error en carga de clase documento"+ e);
                this.Close();
                return documento;
            }
        }

        private void buttonReferencia_Click(object sender, EventArgs e)
        {
            new frmReferencia(documento).ShowDialog();
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDctoGlobal_Validated(object sender, EventArgs e)
        {
            actualizaDescuentos();

        }

        private void actualizaDescuentos()
        {
            actualizaTotal();
            Decimal valorNeto = Convert.ToDecimal(labelSubTotal.Text.Replace(".", ""));
            Decimal valorIva = Convert.ToInt32(labelIva.Text.Replace(".", ""));
            Decimal valorTotal = Convert.ToInt32(labelMtoTotal.Text.Replace(".", ""));
            Decimal valorDescuento = Decimal.Round(valorNeto * (Convert.ToDecimal(textBoxDctoGlobal.Text.Replace(".", "")) / 100), MidpointRounding.AwayFromZero);
            Decimal exento = Convert.ToDecimal(labelMtoExento.Text.Replace(".", ""));
            valorNeto = Decimal.Round(valorNeto - valorDescuento, MidpointRounding.AwayFromZero);
            valorIva = Decimal.Round(valorNeto * Convert.ToDecimal(0.19), MidpointRounding.AwayFromZero);
            valorTotal = valorNeto + valorIva + exento;
            labelSubTotal.Text = valorNeto.ToString("N0", CultureInfo.CreateSpecificCulture("es-ES"));
            labelIva.Text = valorIva.ToString("N0", CultureInfo.CreateSpecificCulture("es-ES"));
            labelMtoTotal.Text = valorTotal.ToString("N0", CultureInfo.CreateSpecificCulture("es-ES"));
        }

        private void actlizaRowItem()
        {
            for (int i = 0; i < dtgwDetalle.RowCount; i++)
            {
                this.dtgwDetalle.Rows[i].Cells[1].Value = i+1;

            }

        }

        private void dtgwDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtgwDetalle.Columns["elimina"].Index && e.RowIndex >= 0)
            {
                DialogResult result1 = MessageBox.Show("Esta seguro de eliminar? ",
    "ELIMINA",
    MessageBoxButtons.YesNo);
                                if (result1.ToString() == "No")
                                {

                                }
                                else
                                {
                                    dtgwDetalle.Rows.RemoveAt(e.RowIndex);
                                    actlizaRowItem();
                                    actualizaDescuentos();
                                }
            }
        }

        private void buttonEmiteDte_Click(object sender, EventArgs e)
        {

            new frmSelecVenta(this).ShowDialog();
        }

        private void dtgwDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            new frmLineaManual(this).ShowDialog();
        }
     

    }
}