using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Data;
using System.IO;
using System.Runtime.Serialization.Json;

namespace Modelo
{
  public   class UsuarioModel
    {
      public String email { get; set; }
      public String password { get; set; }
      public String nombre { get; set; }
      public String usuario { get; set; }
      public Int32 codSeguridad { get; set; }
      public int id { get; set; }

        public string validaUser(string usuario, string clave)
        {
            string respuesta = "true";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                BaseDato con = new BaseDato();
                OdbcConnection conexion = con.ConnectPostgres();

                OdbcCommand select = new OdbcCommand();
                select.Connection = conexion;
                select.CommandText = "select * from usuario "
                                    + "where \"usuario\" = '" + usuario + "' and \"password\" = '" + clave + "'";
                OdbcDataReader reader = select.ExecuteReader();
                if (reader.HasRows == false)
                {
                    respuesta = "false";
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


            return respuesta;
        }

        public DataTable getUsuarios()
        {
            DataTable datatable = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                BaseDato con = new BaseDato();
                OdbcConnection conexion = con.ConnectPostgres();

                OdbcCommand select = new OdbcCommand();
                select.Connection = conexion;
                select.CommandText = "SELECT * FROM usuario order by id DESC";
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

        public void save(UsuarioModel usuario)
        {

            try
            {
                BaseDato con = new BaseDato();
                OdbcConnection conexion = con.ConnectPostgres();
                OdbcCommand select = new OdbcCommand();
                select.Connection = conexion;
                select.CommandText = "INSERT INTO usuario( "
                                   + " email, password, nombre, usuario, codseguridad) "
                                   + " VALUES ('"
                                   + usuario.email + "','"
                                   + usuario.password +"','"
                                   + usuario.nombre +"','"
                                   + usuario.usuario +"',"
                                   + usuario.codSeguridad + ""
                                   + ");";
                OdbcDataReader reader = select.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }

        }

        public DataTable getUsuarioXId(int id)
        {
            DataTable datatable = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                BaseDato con = new BaseDato();
                OdbcConnection conexion = con.ConnectPostgres();

                OdbcCommand select = new OdbcCommand();
                select.Connection = conexion;
                select.CommandText = "SELECT * FROM usuario where id = " + id + ";";
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

        public void update(UsuarioModel usuario)
        {
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                BaseDato con = new BaseDato();
                OdbcConnection conexion = con.ConnectPostgres();

                OdbcCommand select = new OdbcCommand();
                select.Connection = conexion;
                select.CommandText = "UPDATE usuario SET "
                                    + " email ='" + usuario.email + "',"
                                    + " nombre ='" + usuario.nombre + "',"
                                    + " usuario ='" + usuario.usuario + "',"
                                    + " password ='" + usuario.password + "'"
                                    + " WHERE \"id\" = " + usuario.id + ";";
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

        public string exists(int idUser)
        {
            string respuesta = "True";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                BaseDato con = new BaseDato();
                OdbcConnection conexion = con.ConnectPostgres();

                OdbcCommand select = new OdbcCommand();
                select.Connection = conexion;
                select.CommandText = "select * from usuario "
                                    + "where id = "+ idUser + "";
                OdbcDataReader reader = select.ExecuteReader();
                if (reader.HasRows == false)
                {
                    respuesta = "False";
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


            return respuesta;
        }


    }
}
