using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace Modelo
{
   public  class ConfigModel
    {
        public string clienteProducto { get; set; }
        public string abrirIat { get; set; }

        public ConfigModel getConfig()
        {
            string stringcon = string.Empty;
            RegistroWin regWin = new RegistroWin();
            regWin = regWin.getRegWin();

            this.clienteProducto = regWin.clienteProducto;
            this.abrirIat = regWin.abrirIat;                    

            return this; 
        }
    }
}
