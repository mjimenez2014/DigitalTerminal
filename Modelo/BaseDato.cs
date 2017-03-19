using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Data.SQLite;


namespace Modelo
{
    public class BaseDato
    {
        RegistroWin regWin = new RegistroWin();

        private string stringConn()
        {
            regWin = regWin.getRegWin();
            string stringcon = string.Empty;
            try
            {
                stringcon = "Driver={PostgreSQL UNICODE};Server=" + regWin.ipServer
                                       + ";Port=" + regWin.port
                                       + ";Database=" + regWin.dataBase
                                       + ";Uid=" + regWin.user
                                       + ";Pwd=" + regWin.pass + ";";
                return stringcon;
            }
            catch (Exception ex)
            {
                return "###################### Error al crear el String de Conección: " + ex.Message;
            }


        }

        public OdbcConnection ConnectPostgres()
        {

            string stringConn = this.stringConn();
            OdbcConnection conn = new OdbcConnection(stringConn);
            try
            {
                conn.Open();
            }
            catch (OdbcException ex )
            {
                Console.WriteLine("######################## ERROR EN LA CONECCIÓN BASE DE DATOS: " + ex.Message);
                return null;
            }
            return conn;
        }


    }


}
