using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Runtime.Serialization;

namespace Modelo
{
    [DataContract]
   public class EmpresaModel
    {
        BaseDato con = new BaseDato();

        [DataMember]
        public string Rut { get; set; }
        [DataMember]
        public string RazonSocial { get; set; }
        [DataMember]
        public string GiroEmisor { get; set; }
        [DataMember]
        public Int32 CodigoSiiSucursal { get; set; }
        [DataMember]
        public string Telefono { get; set; }
        [DataMember]
        public string Correo { get; set; }
        [DataMember]
        public Int32 Acteco { get; set; }
        [DataMember]
        public string DireccionOrigen { get; set; }
        [DataMember]
        public string ComunaOrigen { get; set; }
        [DataMember]
        public string CiudadOrigen { get; set; }
        [DataMember]
        public string DirRegionalSII { get; set; }
        [DataMember]
        public string sucurEmisor { get; set; }

        public EmpresaModel getEmpresa()
        {
            
            SqlConnection sqlcon = new SqlConnection();
            try
            {

                OdbcConnection conexion = con.ConnectPostgres();

                OdbcCommand select = new OdbcCommand();
                select.Connection = conexion;
                select.CommandText = "SELECT * FROM empresa ";
                OdbcDataReader reader = select.ExecuteReader();
                while(reader.Read())
                {
                    Rut = reader.GetString(reader.GetOrdinal("rutempresa"));
                    RazonSocial = reader.GetString(reader.GetOrdinal("razonsocial"));
                    GiroEmisor = reader.GetString(reader.GetOrdinal("giroemisor"));
                    CodigoSiiSucursal = reader.GetInt32(reader.GetOrdinal("codigosiisucursal"));
                    Telefono = reader.GetString(reader.GetOrdinal("telefonoemis"));
                    Correo = reader.GetString(reader.GetOrdinal("correoemis"));
                    Acteco = reader.GetInt32(reader.GetOrdinal("acteco"));
                    DireccionOrigen = reader.GetString(reader.GetOrdinal("direccionorigen"));
                    ComunaOrigen = reader.GetString(reader.GetOrdinal("comunaorigen"));
                    CiudadOrigen = reader.GetString(reader.GetOrdinal("ciudadorigen"));
                    DirRegionalSII = reader.GetString(reader.GetOrdinal("dirregionalsii"));
                    sucurEmisor = reader.GetString(reader.GetOrdinal("sucuremisor"));

                }



            }
            catch (Exception ex)
            {

                throw new Exception("Error en la tabal empresa postgres" + ex.Message);
            }

            finally
            {
                sqlcon.Close();
            }

            return this;
        }

        public void update(EmpresaModel empresaModel)
        {

            SqlConnection sqlcon = new SqlConnection();
            try
            {
                OdbcConnection conexion = con.ConnectPostgres();

                OdbcCommand select = new OdbcCommand();
                select.Connection = conexion;
                select.CommandText = 
                                     "UPDATE empresa "
                                   + "SET "
                                   + "\"razonsocial\"='" + empresaModel.RazonSocial + "',"
                                   + "\"giroemisor\"='" + empresaModel.GiroEmisor + "',"
                                   + "\"codigosiisucursal\"=" + empresaModel.CodigoSiiSucursal + ","
                                   + "\"telefonoemis\"='" + empresaModel.Telefono + "',"
                                   + "\"correoemis\"='" + empresaModel.Correo + "',"
                                   + "\"acteco\"=" + empresaModel.Acteco + ","
                                   + "\"direccionorigen\"='" + empresaModel.DireccionOrigen + "',"
                                   + "\"comunaorigen\"='" + empresaModel.ComunaOrigen + "',"
                                   + "\"ciudadorigen\"='" + empresaModel.CiudadOrigen + "'"
                                   + "WHERE \"rutempresa\" = '" + empresaModel.Rut + "';";
                OdbcDataReader reader = select.ExecuteReader();
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




    }
}
