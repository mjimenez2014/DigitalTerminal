using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Data;

namespace Modelo
{
   public class FolioModel
    {
       public string estado { get; set; }
       public int folio { get; set; }
       public int idcaf { get; set; }
       public string codSucSii { get; set; }

       public Int32 getUltimoFolio(Int32 idCaf)
       {
           Int32 ultimoFolio = 0;
           SqlConnection sqlcon = new SqlConnection();
          try
          {
               BaseDato con = new BaseDato();
               OdbcConnection conexion = con.ConnectPostgres();
               OdbcCommand select = new OdbcCommand();
               select.Connection = conexion;
               select.CommandText = "select min(folio) from folio where estado = 'DISPONIBLE' and idcaf = " + idCaf + ";";
               OdbcDataReader reader = select.ExecuteReader();
               while (reader.Read())
               {
                   ultimoFolio = Convert.ToInt32(reader.GetValue(0));
               }
              // modificaEstado("OCUPADO", ultimoFolio,idCaf);
           }
           catch (Exception ex)
           {
               throw new Exception("Error" + ex.Message);
           }
           finally
           {
               sqlcon.Close();
           }
           
           return ultimoFolio;
           //select min(folio) from folio where estado = 'DISPONIBLE'
           //cambiar a estado a ocupado
           // validar con try catch
       }

       public void modificaEstado(String estado, Int32 folio, int idCaf)
       {
           SqlConnection sqlcon = new SqlConnection();
           try{
           BaseDato con = new BaseDato();
           OdbcConnection conexion = con.ConnectPostgres();
           OdbcCommand select2 = new OdbcCommand();
           select2.Connection = conexion;
           select2.CommandText = "update folio  set estado = '"+estado+"' where folio = " + folio + "and idcaf = " + idCaf + ";";
           OdbcDataReader reader2 = select2.ExecuteReader();
                      }
           catch (Exception ex)
           {
               throw new Exception("Error" + ex.Message);
           }
           finally
           {
               sqlcon.Close();
           }
       }

       public Int32 getUltimoFolioPedido()
       {
           Int32 ultimoFolio = 0;
           SqlConnection sqlcon = new SqlConnection();
           try
           {
               BaseDato con = new BaseDato();
               OdbcConnection conexion = con.ConnectPostgres();
               OdbcCommand select = new OdbcCommand();
               select.Connection = conexion;
               select.CommandText = "select MAX(\"Folio\") from documento where \"TipoDTE\" = '802'";
               OdbcDataReader reader = select.ExecuteReader();
               while (reader.Read())
               {
                   ultimoFolio = Convert.ToInt32(reader.GetValue(0));
               }
           }
           catch (Exception ex)
           {
               throw new Exception("Error" + ex.Message);
           }
           finally
           {
               sqlcon.Close();
           }

           ultimoFolio = ultimoFolio + 1;
           return ultimoFolio;

           //select min(folio) from folio where estado = 'DISPONIBLE'
           //cambiar a estado a ocupado
           // validar con try catch
       }

       public DataTable getFolioXId(Int32 id)
       {
           DataTable datatable = new DataTable();
           SqlConnection sqlcon = new SqlConnection();
           try
           {
               BaseDato con = new BaseDato();
               OdbcConnection conexion = con.ConnectPostgres();

               OdbcCommand select = new OdbcCommand();
               select.Connection = conexion;
               select.CommandText = "SELECT * FROM folio where idcaf = "+id+" order by folio ASC";
               OdbcDataReader reader = select.ExecuteReader();
               datatable.Load(reader);

           }
           catch (Exception ex)
           {
               datatable = null;
               throw new Exception("Error" + ex.Message);
           }

           finally
           {
               sqlcon.Close();
           }

           return datatable;
       }

       public void save(FolioModel foliomodel)


       {
           try
           {
               BaseDato con = new BaseDato();
               OdbcConnection conexion = con.ConnectPostgres();

               OdbcCommand select = new OdbcCommand();
               select.Connection = conexion;
               select.CommandText = "INSERT INTO folio("
                   + "folio, estado, idcaf, \"codSucSii\")"
                   + " VALUES ("
                   + foliomodel.folio + ",'"
                   + "DISPONIBLE" + "',"
                   + foliomodel.idcaf + ",'"
                   + foliomodel.codSucSii + "'"
                   + ");";
               OdbcDataReader reader = select.ExecuteReader();

           }
           catch (Exception ex)
           {
               throw new Exception("Error" + ex.Message);
           }
       }

       public string exist(int idCAf, int folio)
       {
           string respuesta = "False";
           try
           {
               BaseDato con = new BaseDato();
               OdbcConnection conexion = con.ConnectPostgres();

               OdbcCommand select = new OdbcCommand();
               select.Connection = conexion;
               select.CommandText = "SELECT * FROM folio where idcaf = " + idCAf + " and folio = " + folio +";";
               OdbcDataReader reader = select.ExecuteReader();
               if (reader.RecordsAffected != 0)
               {
                   respuesta = "True";
               }
           }
           catch (Exception ex)
           {
               throw new Exception("Error" + ex.Message);
           }
           return respuesta;
       }


    }
}
