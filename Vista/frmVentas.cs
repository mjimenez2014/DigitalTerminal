﻿using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Modelo;
using System.Globalization;

namespace Vista
{
    public partial class frmVentas : Form
    {
        DataTable dataTable = new DataTable();
        String nombreDoc = String.Empty;
        UsuarioModel usuarioM;
        ConfigModel configModel = new ConfigModel();
        RegistroWin regWin = new RegistroWin();
        string desde = string.Empty;
        string hasta = string.Empty;
        public frmVentas()
        {
            InitializeComponent();
        }
        public frmVentas(UsuarioModel usuarioM)
        {
            InitializeComponent();
            this.usuarioM = usuarioM;
        }


        public void actualizaDG()
        {
             desde = Convert.ToDateTime(dateTimePickerDesde.Value).ToString("yyyy-MM-dd");
             hasta = Convert.ToDateTime(dateTimePickerHasta.Value).ToString("yyyy-MM-dd");

            dataGridView1.Rows.Clear();
            dataTable = new DocumentoModel().getAllDocDTxFecha(desde, hasta);
            foreach (DataRow fila in dataTable.Rows)
            {
                Int32 n = this.dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = fila["nombre"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = fila["TipoDTE"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = fila["Folio"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = fila["FchEmis"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = fila["RznSocRecep"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = fila["MntTotal"].ToString();
                dataGridView1.Rows[n].Cells[6].Value = "    VER    ";
                dataGridView1.Rows[n].Cells[7].Value = "    IMPRIMIR    ";

            }
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            configModel = configModel.getConfig();
            regWin = regWin.getRegWin();
            if (configModel.abrirIat == "True") System.Diagnostics.Process.Start(@"" + regWin.unidadIat + ":/IatFiles/IatDteBridge.exe");
            try
            {
                pictureBoxLogo.Image = new Bitmap(@"" + regWin.unidadDT + ":/DigitalTerminal/img/logo.jpg");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar imagen de logo " + ex.Message);
            }
            this.btnPedidos.Select();
            actualizaDG();
        }



        private void paisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmPaises().ShowDialog();
        }



        private void btnPedidos_Click(object sender, EventArgs e)
        {
            new frmNewVenta(this).ShowDialog();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            new frmArchivosMaestros().ShowDialog();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            new DocumentoModel().getDocumento(33, 1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["abrir"].Index && e.RowIndex >= 0)
            {
                String tipoDte = dataGridView1.Rows[e.RowIndex].Cells["Tipo_Dte"].Value.ToString();
                String folio = dataGridView1.Rows[e.RowIndex].Cells["Folio"].Value.ToString();
                nombreDoc = dataGridView1.Rows[e.RowIndex].Cells["Documento"].Value.ToString();
                getDoc(Convert.ToInt32(tipoDte), Convert.ToInt32(folio));
            }

            if (e.ColumnIndex == dataGridView1.Columns["imprimir"].Index && e.RowIndex >= 0)
            {
                String tipoDte = dataGridView1.Rows[e.RowIndex].Cells["Tipo_Dte"].Value.ToString();
                String folio = dataGridView1.Rows[e.RowIndex].Cells["Folio"].Value.ToString();
                DocumentoModel documento = new DocumentoModel();
                documento = documento.getDocumento(Convert.ToInt32(tipoDte), Convert.ToInt32(folio));
                if (documento.TipoDTE != 802)
                {
                    string dirPdf = @"" + regWin.unidadIat + ":/IatFiles/file/pdf/PRINT_" + documento.RUTEmisor + "_" + tipoDte + "_" + folio + ".pdf";
                    System.Diagnostics.Process.Start(dirPdf);
                }

            }
        }

        public void getDoc(int tipo, int folio)
        {
            DocumentoModel documento = new DocumentoModel();
            documento = documento.getDocumento(tipo, folio);
            frmNewVenta pos = new frmNewVenta(documento, this);
            pos.textBoxRutRecep.Text = documento.RUTRecep;
            pos.textBoxRutRecep.Enabled = false;
            pos.labelRznSocRecep.Text = documento.RznSocRecep;
            pos.labelGiroRecep.Text = documento.GiroRecep;
            pos.labelTelefonoRecep.Text = documento.TelRecep;
            pos.labelDireccionRecep.Text = documento.DirRecep;
            pos.labelCiudadRecep.Text = documento.CiudadRecep;
            pos.labelComunaRecep.Text = documento.CmnaRecep;
            pos.lblNomForm.Text = "Tipo Documento: "+ nombreDoc + " Folio: "+ folio;
            pos.textBoxOC.Text = documento.NroOrdenCompra;
            pos.dateTimePickerFchEmis.Value = Convert.ToDateTime(documento.FchEmis);
            pos.textBoxCita.Text = documento.NroCita;
            pos.textBoxSello.Text = documento.Sello;
            pos.textBoxFormaPago.Text = documento.formaPago;
            // Cargo Detalle
            foreach (Detalle detalle in documento.detalle)
            {
                Int32 n = pos.dtgwDetalle.Rows.Add();
                pos.dtgwDetalle.Rows[n].Cells["elimina"].Value = "-";
                pos.dtgwDetalle.Rows[n].Cells["item"].Value = n + 1;
                pos.dtgwDetalle.Rows[n].Cells["codigo"].Value = detalle.VlrCodigo;
                pos.dtgwDetalle.Rows[n].Cells["nombre"].Value = detalle.NmbItem;
                pos.dtgwDetalle.Rows[n].Cells["Precio_Neto"].Value = detalle.PrcItem.ToString();
                pos.dtgwDetalle.Rows[n].Cells["precio"].Value = detalle.PrcBruItem.ToString("N0", CultureInfo.CreateSpecificCulture("es-ES"));
                pos.dtgwDetalle.Rows[n].Cells["cantidad"].Value = detalle.QtyItem.ToString("N0", CultureInfo.CreateSpecificCulture("es-ES")).Replace(",",".");
                pos.dtgwDetalle.Rows[n].Cells["unmditem"].Value = detalle.UnmdItem;
                pos.dtgwDetalle.Rows[n].Cells["desc"].Value = detalle.DescuentoPct;
                pos.dtgwDetalle.Rows[n].Cells["Monto_Descuento"].Value = detalle.DescuentoMonto.ToString("N0", CultureInfo.CreateSpecificCulture("es-ES"));
                pos.dtgwDetalle.Rows[n].Cells["Total_Neto"].Value = detalle.MontoItem.ToString("N0", CultureInfo.CreateSpecificCulture("es-ES"));
                pos.dtgwDetalle.Rows[n].Cells["total"].Value = detalle.MontoBruItem.ToString("N0", CultureInfo.CreateSpecificCulture("es-ES"));
                if (detalle.IndExe == "1")
                {
                    pos.dtgwDetalle.Rows[n].Cells["exento"].Value = "True";
                    pos.dtgwDetalle.Rows[n].Cells["Total_Neto"].Value = "";
                }
                else
                {
                    pos.dtgwDetalle.Rows[n].Cells["exento"].Value = "False";
                }
                if (detalle.DscItem != null)
                {
                    pos.dtgwDetalle.Rows[n].Cells["DscItem"].Value = detalle.DscItem.ToString();
                }
            }
            // Cargo Totales
            //pos.textBoxDctoGlobal.Text = documento.dscRcgGlobal; // TODO
            pos.labelSubTotal.Text = documento.MntNeto.ToString("N0", CultureInfo.CreateSpecificCulture("es-ES"));
            pos.labelMtoExento.Text = documento.MntExe.ToString("N0", CultureInfo.CreateSpecificCulture("es-ES"));
            pos.labelIva.Text = documento.IVA.ToString("N0", CultureInfo.CreateSpecificCulture("es-ES"));
            //pos.labelImpAdic.Text = documento.imptoReten; // TODO
            pos.labelMtoTotal.Text = documento.MntTotal.ToString("N0", CultureInfo.CreateSpecificCulture("es-ES"));
            //Cargo las referencias

            pos.ShowDialog();

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            actualizaDG();
        }

        private void buttonInforme_Click(object sender, EventArgs e)
        {
            new frmVentasXFecha(desde,hasta).ShowDialog();
        }
    }
}
