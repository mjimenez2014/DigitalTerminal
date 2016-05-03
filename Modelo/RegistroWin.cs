﻿using Microsoft.Win32;
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



        public void creaRegistrosWin()
        {

            if ((Registry.GetValue(@"HKEY_CURRENT_USER\DigitalTerminal", "unidadDT", null) == null)) Registry.SetValue(@"HKEY_CURRENT_USER\DigitalTerminal", "unidadDT", "C");
            if ((Registry.GetValue(@"HKEY_CURRENT_USER\DigitalTerminal", "unidadIat", null) == null)) Registry.SetValue(@"HKEY_CURRENT_USER\DigitalTerminal", "unidadIat", "C");
        }

        public RegistroWin getRegWin()
        {
            RegistroWin regWin = new RegistroWin();
            regWin.unidadDT = Registry.GetValue(@"HKEY_CURRENT_USER\DigitalTerminal", "unidadDT", null).ToString();
            regWin.unidadIat = Registry.GetValue(@"HKEY_CURRENT_USER\DigitalTerminal", "unidadIat", null).ToString();
            return regWin;

        }
    }
}