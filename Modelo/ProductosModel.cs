﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;

namespace Modelo
{
    public class ProductosModel
    {
        public int id { get; set; }
        public String nombre { get; set; }
        public String codigoInt { get; set; }
        public decimal precioNeto { get; set; }
        public Int32 precioventa { get; set; }
        public string exento { get; set; } 
        public string unmditem { get; set; }
        List<Impuesto> impuesto { get; set; }

        public ProductosModel()
        {
        }

        public ProductosModel(int id, String nombre, String codigoInt, decimal precioNeto, Int32 precioVenta)
        {
            this.id = id;
            this.nombre = nombre;
            this.codigoInt = codigoInt;
            this.precioNeto = precioNeto;
            this.precioventa = precioventa;

        }

        public DataTable getProductos()
        {
            DataTable datatable = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                BaseDato con = new BaseDato();
                OdbcConnection conexion = con.ConnectPostgres();

                OdbcCommand select = new OdbcCommand();
                select.Connection = conexion;
                select.CommandText = "SELECT * FROM productos";
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

        public DataTable getProdXCod(String codProd)
        {
            DataTable datatable = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                BaseDato con = new BaseDato();
                OdbcConnection conexion = con.ConnectPostgres();

                OdbcCommand select = new OdbcCommand();
                select.Connection = conexion;
                select.CommandText = "SELECT * FROM producto where \"codigoInt\" = '" + codProd+ "'";
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

        public DataTable getProdXCodSistema(Int32 codProd)
        {
            DataTable datatable = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                BaseDato con = new BaseDato();
                OdbcConnection conexion = con.ConnectPostgres();

                OdbcCommand select = new OdbcCommand();
                select.Connection = conexion;
                select.CommandText = "SELECT * FROM producto where \"id\" = '" + codProd + "'";
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

        public DataTable getProdXNombre(String nombreProducto)
        {
            DataTable datatable = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                BaseDato con = new BaseDato();
                OdbcConnection conexion = con.ConnectPostgres();

                OdbcCommand select = new OdbcCommand();
                select.Connection = conexion;
                select.CommandText = "SELECT * FROM producto where nombre LIKE '%" + nombreProducto + "%'";
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

        public void save(ProductosModel producto)
        {
            try
            {
                BaseDato con = new BaseDato();
                OdbcConnection conexion = con.ConnectPostgres();
                OdbcCommand select = new OdbcCommand();
                select.Connection = conexion;
                select.CommandText = 
                                     "INSERT INTO producto("
                                   // +"id, "
                                    +"nombre, "
                                    +"\"codigoInt\", "
                                    + "unmditem, "
                                    + "\"precioNeto\", "
                                    +"\"precioVenta\","
                                    + "\"exento\""
                                   //+"codimpuesto "
                                    +") VALUES ('"
                                    //+ producto.id +",'"//"id, "
                                    + producto.nombre + "','"//"nombre, "
                                    + producto.codigoInt + "','"//"\"codigoInt\", "
                                    + producto.unmditem + "',"//"unmditem, "
                                    + producto.precioNeto + ","//"\"precioNeto\", "
                                    + producto.precioventa + ",'"//"\"precioVenta\", "
                                    + producto.exento + "'"//"\"precioVenta\", "
                                   // + "codimpuesto "
                                    +");";
                OdbcDataReader reader = select.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }
        }

        public void update(ProductosModel producto)
        {
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                BaseDato con = new BaseDato();
                OdbcConnection conexion = con.ConnectPostgres();

                OdbcCommand select = new OdbcCommand();
                select.Connection = conexion;
                select.CommandText = "UPDATE producto SET "
                                    + "\"nombre\"='" + producto.nombre + "',"
                                    + "\"codigoInt\"='" + producto.codigoInt+"',"
                                    + "\"unmditem\"='" + producto.unmditem+"',"
                                    + "\"precioNeto\"="+producto.precioNeto+","
                                    + "\"precioVenta\"="+producto.precioventa+","
                                    + "\"exento\"='"+producto.exento+"'"
                                    + "WHERE \"id\" = " + producto.id + ";";
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

    public class Impuesto
    {
        Int32 codImpuesto { get; set; }
        Int32 codProducto { get; set; }
        string nomimpuesto { get; set; }
        float valorimpuesto {get; set;}

        public Impuesto get(int codProducto)
        {


            return this;
        }
    }
}
