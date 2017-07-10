using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Json
    {
        public void createJson(DocumentoModel documento)
        {
            RegistroWin regWin = new RegistroWin();
            string fileNameJson = string.Empty;

            if (documento.TipoDTE != 802)
            {
                regWin = regWin.getRegWin();
                try
                {
                     fileNameJson = @"" + regWin.rutaPrint +"\\"+ documento.TipoDTE + "_" + documento.RUTEmisor + "_" + documento.Folio + ".json";
                }
                catch(Exception ex)
                {
                    Console.WriteLine("#####  error al guardar JSON #############"+ ex);
                }

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileNameJson, false, Encoding.GetEncoding("ISO-8859-1")))
                {
                    file.WriteLine("{");
                    file.WriteLine("\"TipoDTE\": "+documento.TipoDTE+",");
                    file.WriteLine("\"Folio\": "+documento.Folio+",");
                    file.WriteLine("\"FchEmis\": \""+documento.FchEmis+"\",");
                    file.WriteLine("\"IndNoRebaja\": "+documento.IndNoRebaja+",");
                    file.WriteLine("\"TipoDespacho\": "+documento.TipoDespacho+",");
                    file.WriteLine("\"IndTraslado\": "+documento.IndTraslado+",");
                    file.WriteLine("\"TpoImpresion\": \""+documento.TpoImpresion+"\",");
                    file.WriteLine("\"IndServicio\": "+documento.IndServicio+",");
                    file.WriteLine("\"MntBruto\": "+documento.MntBruto+",");
                    file.WriteLine("\"FmaPago\": "+documento.FmaPago+",");
                    //for
                    file.WriteLine("  \"MntPagos\":");
                    file.WriteLine("  [");
                    file.WriteLine("  {\"FchPago\": \"\", \"MntPago\": 0}");
                    file.WriteLine("  ],");
                    file.WriteLine("\"MedioPago\": \"\",");
                    file.WriteLine("\"CondVenta\": \"\",");
                    file.WriteLine("\"FchVenc\": \"\",");
                    file.WriteLine("\"RUTEmisor\": \""+documento.RUTEmisor+"\",");
                    file.WriteLine("\"RznSoc\": \""+documento.RznSoc+"\",");
                    file.WriteLine("\"GiroEmis\": \""+documento.GiroEmis+"\",");
                    file.WriteLine("\"CdgSIISucur\": "+documento.CdgSIISucur+",");
                    file.WriteLine("\"DirOrigen\": \""+documento.DirOrigen+"\",");
                    file.WriteLine("\"CmnaOrigen\": \""+documento.CmnaOrigen+"\",");
                    file.WriteLine("\"CiudadOrigen\": \""+documento.CiudadOrigen+"\",");
                    file.WriteLine("\"CdgVendedor\": \""+documento.CdgVendedor+"\",");
                    file.WriteLine("\"NomVendedor\": \""+documento.NomVendedor+"\",");
                    file.WriteLine("\"BodEmis\": \"\",");
                    file.WriteLine("\"RUTMandante\": \"\",");
                    file.WriteLine("\"RUTRecep\": \""+documento.RUTRecep+"\",");
                    file.WriteLine("\"RznSocRecep\": \""+documento.RznSocRecep+"\",");
                    file.WriteLine("\"GiroRecep\": \""+documento.GiroRecep+"\",");
                    file.WriteLine("\"DirRecep\": \""+documento.DirRecep+"\",");
                    file.WriteLine("\"CmnaRecep\": \""+documento.CmnaRecep+"\",");
                    file.WriteLine("\"CiudadRecep\": \""+documento.CiudadRecep+"\",");
                    file.WriteLine("\"TelRecep\": \""+documento.TelRecep+"\",");
                    file.WriteLine("\"BodRecep\": \"\",");
                    file.WriteLine("\"RUTSolicita\": \"\",");
                    file.WriteLine("\"RUTTrans\": \"\",");
                    file.WriteLine("\"NombreChofer\": \"\",");
                    file.WriteLine("\"Patente\": \"\",");
                    file.WriteLine("\"DirDest\": \"\",");
                    file.WriteLine("\"CmnaDest\": \"\",");
                    file.WriteLine("\"NroOrdenCompra\": " + documento.NroOrdenCompra+",");
                    file.WriteLine("\"NroCita\": " + documento.NroCita+ ",");
                    file.WriteLine("\"Sello\": " + documento.Sello + ",");
                    file.WriteLine("\"MntNeto\": " + documento.MntNeto + ",");
                    file.WriteLine("\"MntExe\": "+documento.MntExe+",");
                    file.WriteLine("\"MntBase\": 0,");
                    file.WriteLine("\"MntMargenCom\": 0,");
                    file.WriteLine("\"TasaIVA\": "+documento.TasaIVA+",");
                    file.WriteLine("\"IVA\": "+documento.IVA+",");
                    file.WriteLine("  \"imptoReten\":");
                    file.WriteLine("  [");
                    file.WriteLine("  ],");
                    file.WriteLine("\"IVANoRet\": 0,");
                    file.WriteLine("\"CredEC\": 0,");
                    file.WriteLine("\"GrntDep\": 0,");
                    file.WriteLine("\"ValComNeto\": 0,");
                    file.WriteLine("\"ValComExe\": 0,");
                    file.WriteLine("\"ValComIVA\": 0,");
                    file.WriteLine("\"MntTotal\": "+documento.MntTotal+",");
                    file.WriteLine("\"MontoNF\": 0,");
                    file.WriteLine("  \"detalle\":");
                    file.WriteLine("  [");
                    //for each
                    int lineaFinalDetalle = 0;
                    foreach (var fila in documento.detalle)
                    {
                        file.Write("   {\"NroLinDet\": "+fila.NroLinDet+", \"TpoCodigo\": \"PLU\", \"VlrCodigo\": "+fila.VlrCodigo+", \"CodCatalog\": \"\", \"TpoDocLiq\": \"\", \"IndExe\": \""+fila.IndExe+"\", \"NmbItem\": \""+fila.NmbItem+ "\", \"DscItem\": \"" + fila.DscItem + "\", \"UnmdItem\": \"" + fila.UnmdItem+"\", \"QtyItem\": "+fila.QtyItem+", \"PrcItem\": "+fila.PrcItem+", \"PrcBruItem\": "+fila.PrcBruItem+", \"DescuentoPct\": "+fila.DescuentoPct+", \"DescuentoMonto\": "+fila.DescuentoMonto+", \"DescuentoBruMonto\": "+fila.DescuentoBruMonto+", \"CodImpAdic\": \""+fila.CodImpAdic+"\", \"MontoItem\": "+fila.MontoItem+",\"MontoBruItem\": "+fila.MontoBruItem);
                        if (lineaFinalDetalle != documento.detalle.Count - 1)
                        {
                            file.WriteLine(" },");
                            lineaFinalDetalle = lineaFinalDetalle + 1;
                        }
                        else
                        {
                            file.WriteLine(" }");
                        }
                    }
                    //fin foreach
                    file.WriteLine("  ],");
                    file.WriteLine("  \"dscRcgGlobal\":");
                    file.WriteLine("  [");
                    //foreach
                    int lineaFinalDescuentos = 0;
                    foreach (var filaDes in documento.dscRcgGlobal)
                    {
                        file.Write("   {\"NroLinDR\": "+filaDes.NroLinDR+", \"TpoMov\": \""+filaDes.TpoMov+"\", \"GlosaDR\": \""+filaDes.GlosaDR+"\", \"TpoValor\": \""+filaDes.TpoValor+"\", \"ValorDR\": "+filaDes.ValorDR+", \"IndExeDR\": "+filaDes.IndExeDR);
                        if (lineaFinalDescuentos != documento.dscRcgGlobal.Count - 1)
                        {
                            file.WriteLine(" },");
                            lineaFinalDescuentos = lineaFinalDescuentos + 1;
                        }
                        else
                        {
                            file.WriteLine(" }");
                        }
                    } 
                    //fin foreach
                    file.WriteLine("  ],");
                    file.WriteLine("  \"Referencia\":");
                    file.WriteLine("  [");
                    //foreach
                    int lineaFinalRef = 0;
                    foreach (var filaRef in documento.Referencia)
                    {
                        file.Write("   { \"NroLinRef\": "+filaRef.NroLinRef+", \"TpoDocRef\": \""+filaRef.TpoDocRef+"\", \"IndGlobal\": "+filaRef.IndGlobal+", \"FolioRef\": \""+filaRef.FolioRef+"\", \"RutOtr\": \""+filaRef.RUTOtr+"\", \"IdAdicOtr\": \""+filaRef.IdAdicOtr+"\", \"FchRef\": \""+filaRef.FchRef+"\", \"CodRef\": "+filaRef.CodRef+", \"RazonRef\": \""+filaRef.RazonRef+"\"");
                        if (lineaFinalRef != documento.Referencia.Count - 1)
                        {
                            file.WriteLine(" },");
                            lineaFinalRef = lineaFinalRef + 1;
                        }
                        else
                        {
                            file.WriteLine(" }");
                        }
                    }
                    //fin foreach
                    file.WriteLine("  ],");
                    file.WriteLine("  \"Comisiones\":");
                    file.WriteLine("  [");
                    file.WriteLine("   {\"NroLinCom\": 0, \"TipoMovim\": \"\", \"Glosa\": \"\", \"ValComNeto\": 0,\"ValComExe\": 0,\"ValComIVA\": 0}");
                    file.WriteLine("  ]");
                    file.WriteLine("}");
                }
                   
            }
        }
    }
}
