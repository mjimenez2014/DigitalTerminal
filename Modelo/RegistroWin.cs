using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
   public class RegistroWin
    {
        public string unidadDT { get; set; }
        public string unidadIat { get; set; }
        public string itemManual { get; set; }
        public string ipServer { get; set; }
        public string port { get; set; }
        public string dataBase { get; set; }
        public string user { get; set; }
        public string pass { get; set; }
        public string clienteProducto { get; set; }
        public string abrirIat { get; set; }
        public string rutaPrint { get; set; }



        public string creaRegistrosWin()
        {
            try
            {
                if ((Registry.GetValue(@"HKEY_CURRENT_USER\DigitalTerminal", "unidadDT", null) == null)) Registry.SetValue(@"HKEY_CURRENT_USER\DigitalTerminal", "unidadDT", "C");
                if ((Registry.GetValue(@"HKEY_CURRENT_USER\DigitalTerminal", "unidadIat", null) == null)) Registry.SetValue(@"HKEY_CURRENT_USER\DigitalTerminal", "unidadIat", "C");
                if ((Registry.GetValue(@"HKEY_CURRENT_USER\DigitalTerminal", "itemManual", null) == null)) Registry.SetValue(@"HKEY_CURRENT_USER\DigitalTerminal", "itemManual", "False");
                if ((Registry.GetValue(@"HKEY_CURRENT_USER\DigitalTerminal\BD", "ipServer", null) == null)) Registry.SetValue(@"HKEY_CURRENT_USER\DigitalTerminal\BD", "ipServer", "192.168.1.10");
                if ((Registry.GetValue(@"HKEY_CURRENT_USER\DigitalTerminal\BD", "port", null) == null)) Registry.SetValue(@"HKEY_CURRENT_USER\DigitalTerminal\BD", "port", "5432");
                if ((Registry.GetValue(@"HKEY_CURRENT_USER\DigitalTerminal\BD", "dataBase", null) == null)) Registry.SetValue(@"HKEY_CURRENT_USER\DigitalTerminal\BD", "dataBase", "digitalterminal");
                if ((Registry.GetValue(@"HKEY_CURRENT_USER\DigitalTerminal\BD", "user", null) == null)) Registry.SetValue(@"HKEY_CURRENT_USER\DigitalTerminal\BD", "user", "postgres");
                if ((Registry.GetValue(@"HKEY_CURRENT_USER\DigitalTerminal\BD", "pass", null) == null)) Registry.SetValue(@"HKEY_CURRENT_USER\DigitalTerminal\BD", "pass", "elpreciosodt3");
                if ((Registry.GetValue(@"HKEY_CURRENT_USER\DigitalTerminal\Config", "clienteProducto", null) == null)) Registry.SetValue(@"HKEY_CURRENT_USER\DigitalTerminal\Config", "clienteProducto", "False");
                if ((Registry.GetValue(@"HKEY_CURRENT_USER\DigitalTerminal\Config", "abrirIat", null) == null)) Registry.SetValue(@"HKEY_CURRENT_USER\DigitalTerminal\Config", "abrirIat", "False");
                if ((Registry.GetValue(@"HKEY_CURRENT_USER\DigitalTerminal\Config", "rutaPrint", null) == null)) Registry.SetValue(@"HKEY_CURRENT_USER\DigitalTerminal\Config", "rutaPrint", "SIN RUTA");
                return "los registros fueron creados";
            } catch(Exception ex)
            {
                return "Error al crear registros: " + ex.Message; 
            }
        }

        public RegistroWin getRegWin()
        {
            RegistroWin regWin = new RegistroWin();
            try
            {   regWin.unidadDT = Registry.GetValue(@"HKEY_CURRENT_USER\DigitalTerminal", "unidadDT", null).ToString();
                regWin.unidadIat = Registry.GetValue(@"HKEY_CURRENT_USER\DigitalTerminal", "unidadIat", null).ToString();
                regWin.itemManual = Registry.GetValue(@"HKEY_CURRENT_USER\DigitalTerminal", "itemManual", null).ToString();
                regWin.ipServer = Registry.GetValue(@"HKEY_CURRENT_USER\DigitalTerminal\BD", "ipServer", null).ToString();
                regWin.port = Registry.GetValue(@"HKEY_CURRENT_USER\DigitalTerminal\BD", "port", null).ToString();
                regWin.dataBase = Registry.GetValue(@"HKEY_CURRENT_USER\DigitalTerminal\BD", "dataBase", null).ToString();
                regWin.user = Registry.GetValue(@"HKEY_CURRENT_USER\DigitalTerminal\BD", "user", null).ToString();
                regWin.pass = Registry.GetValue(@"HKEY_CURRENT_USER\DigitalTerminal\BD", "pass", null).ToString();
                regWin.clienteProducto = Registry.GetValue(@"HKEY_CURRENT_USER\DigitalTerminal\Config", "clienteProducto", null).ToString();
                regWin.abrirIat = Registry.GetValue(@"HKEY_CURRENT_USER\DigitalTerminal\Config", "clienteProducto", null).ToString();
                regWin.rutaPrint = Registry.GetValue(@"HKEY_CURRENT_USER\DigitalTerminal\Config", "rutaPrint", null).ToString();

                return regWin;
            }
            catch(Exception)
            {
                return regWin;
            }

        }
    }
}
