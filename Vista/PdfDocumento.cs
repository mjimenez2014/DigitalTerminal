using System;
using Modelo;
using System.Drawing.Printing;
using System.Drawing;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.Diagnostics;
using PdfSharp.Drawing.Layout;

namespace Vista
{
   public class PdfDocumento
    {
        public DocumentoModel docModel { get; set; }
        RegistroWin regWin = new RegistroWin();
        string nombreDocumento = string.Empty;



        public void OpenPdfDocument(object sender, PrintPageEventArgs ev)
        {
            int lineaCabecera = 20;
            regWin = regWin.getRegWin();
            Pen p = new Pen(Color.Red, 3); //cuadro de Folio y nomre doc
            Pen p2 = new Pen(Color.Black, 1);
            StringFormat alignCenter = new StringFormat();
            alignCenter.Alignment = StringAlignment.Center;
            StringFormat alignRight = new StringFormat();
            alignRight.Alignment = StringAlignment.Near;
            StringFormat alignLeft = new StringFormat();
            alignLeft.Alignment = StringAlignment.Far;
            //---------------------- Cabecera ----------------------------------//
            //Logo
            ev.Graphics.DrawImage(Image.FromFile((@"" + regWin.unidadDT + ":/DigitalTerminal/img/logo.jpg")), new Rectangle(10, lineaCabecera, 150, 90), new Rectangle(0, 0, 250, 150), GraphicsUnit.Pixel);
            //Datos del emisor
            //Rectangle datosEmisor = new Rectangle(170, 20, 400, 60);
            //ev.Graphics.DrawRectangle(p2,datosEmisor);
            ev.Graphics.DrawString(docModel.RznSoc, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Rectangle(170, lineaCabecera, 400, 60));
            lineaCabecera += 20;
            ev.Graphics.DrawString(docModel.GiroEmis, new Font("Arial", 7, FontStyle.Bold), Brushes.Black, new Rectangle(170, lineaCabecera, 400, 60));
            lineaCabecera += 15;
            ev.Graphics.DrawString("CASA MATRIZ: " + docModel.DirOrigen + " - " + docModel.CmnaOrigen + " FONO: " + docModel.Telefono, new Font("Arial", 7, FontStyle.Bold), Brushes.Black, new Rectangle(170, lineaCabecera, 400, 60));
            //Datos de Folio y nombre doc
            // Agrega separadores al rut
            string rutemisor = docModel.RUTEmisor;
            rutemisor = rutemisor.Insert(2, ".");
            rutemisor = rutemisor.Insert(6, ".");
            ev.Graphics.DrawRectangle(p, new Rectangle(580, 20, 260, 99));
            ev.Graphics.DrawString("R.U.T.: " + rutemisor, new Font("Arial", 10, FontStyle.Bold), Brushes.Red, new Rectangle(580, 30, 260, 100), alignCenter);
            ev.Graphics.DrawString("DTE NO ASIGNADO", new Font("Arial", 10, FontStyle.Bold), Brushes.Red, new Rectangle(580, 55, 260, 100), alignCenter);
            ev.Graphics.DrawString("N° folio no asignado", new Font("Arial", 10, FontStyle.Bold), Brushes.Red, new Rectangle(580, 90, 260, 100), alignCenter);
            //Oficina S.I.I Emisor
            ev.Graphics.DrawString(docModel.DirRegionalSII, new Font("Arial", 10, FontStyle.Bold), Brushes.Red, new Rectangle(580, 120, 260, 100), alignCenter);
            //fecha Emis.
            // convierte fecha
            DateTime fechaemis = Convert.ToDateTime(docModel.FchEmis);
            int dia = fechaemis.Day;
            string mesletra = fechaemis.ToString("MMMMM");
            int ano = fechaemis.Year;
            ev.Graphics.DrawString("Santiago, " + dia + " de " + mesletra + " de " + ano, new Font("Arial", 9, FontStyle.Bold), Brushes.Red, new Rectangle(580, 140, 260, 100), alignLeft);

            //Datos del Recèptor
            Rectangle datosReceptor = new Rectangle(10, 160, 830, 120);
            ev.Graphics.DrawRectangle(p2, datosReceptor);


            //---------------------- Detalle ----------------------------------//
            Rectangle datosDetalle = new Rectangle(10, 290, 830, 400);
            ev.Graphics.DrawRectangle(p2, datosDetalle);

        }


        public void vistaPrevia()
        {
            int lineaCabecera = 10;
            regWin = regWin.getRegWin();
            PdfDocument document = new PdfDocument();
            XFont fArial10 = new XFont("Arial", 10,XFontStyle.Bold);
            XFont fArial9 = new XFont("Arial", 9, XFontStyle.Bold);
            XFont fArial8 = new XFont("Arial", 8,XFontStyle.Bold);
            XFont fArial7 = new XFont("Arial", 7, XFontStyle.Bold);


            XPen pRed = new XPen(XColors.Red);
            XPen pBlack = new XPen(XColors.Black);
 
           // document.Info.Title = "Created with PDFsharp";
            // Create an empty page
            PdfPage page = document.AddPage();
           
            // Get an XGraphics object for drawing
            XGraphics gfx = XGraphics.FromPdfPage(page);
            // Create a font

            //Logo
            gfx.DrawImage(XImage.FromFile(@"" + regWin.unidadDT + ":/DigitalTerminal/img/logo.jpg"), 
                new XRect(2, lineaCabecera, 140, 50), new XRect(0, 0, 250, 150), XGraphicsUnit.Point);
            //Datos Emisor

            gfx.DrawString(docModel.RznSoc, fArial10, XBrushes.Black, new XRect(150, 10, 250, 0));
            gfx.DrawString(docModel.GiroEmis, fArial7, XBrushes.Black, new XRect(150, 20, 250, 0));
            gfx.DrawString("CASA MATRIZ: " + docModel.DirOrigen + " - " + " FONO: " + docModel.Telefono,
                fArial7, XBrushes.Black, new XRect(150, 28, 250, 0));
            gfx.DrawString("SUCURSALES: " + docModel.Sucursal , fArial7, XBrushes.Black, new XRect(150, 36, 250, 0));
            gfx.DrawString("CORREO: " + docModel.CorreoEmisor, fArial7, XBrushes.Black, new XRect(150, 44, 250, 0));
            // Datos del emisor
            // Agrega separadores al rut
            string rutemisor = docModel.RUTEmisor;
            rutemisor = rutemisor.Insert(2, ".");
            rutemisor = rutemisor.Insert(6, ".");
            gfx.DrawString("R.U.T: " + rutemisor, fArial9, XBrushes.Red, new XRect(425, 3, 160, 50), XStringFormats.TopCenter);
            gfx.DrawString("DTE NO ASIGNADO", fArial9, XBrushes.Red, new XRect(425, 16, 160, 0), XStringFormats.TopCenter);
            gfx.DrawString("N° folio no asignado", fArial9, XBrushes.Red, new XRect(425, 35, 160, 0), XStringFormats.TopCenter);
            //Rectangulo para tipo y folio DTE
            gfx.DrawRectangle(pRed, new XRect(425,3,160,50)); // Y,X,ancho,alto
                                                              //Fecha Emision
            DateTime fechaemis = Convert.ToDateTime(docModel.FchEmis);
            int dia = fechaemis.Day;
            string mesletra = fechaemis.ToString("MMMMM");
            int ano = fechaemis.Year;
            gfx.DrawString("Santiago, " + dia + " de " + mesletra + " de " + ano, fArial9, XBrushes.Red, new XRect(425, 60, 160, 0));
            gfx.DrawLine(pBlack, 0, 80,590, 80);
            
            // Save the document...
            const string filename = "HelloWorld.pdf";

            document.Save(filename);
            // ...and start a viewer.

            Process.Start(filename);
        }


    }
}
