using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Vista
{
    class MetodosComunes
    {
        public string formatearRut(string rut)
        {
            int cont = 0;
            string format;
            if (rut.Length == 0)
            {
                return "";
            }
            else
            {
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                format = "-" + rut.Substring(rut.Length - 1);
                for (int i = rut.Length - 2; i >= 0; i--)
                {
                    format = rut.Substring(i, 1) + format;
                    cont++;
                    if (cont == 3 && i != 0)
                    {
                        format = "" + format;
                        cont = 0;
                    }
                }
                return format;
            }
        }

        public Int32 getMontoConIva(decimal montoNeto)
        {
            Int32 montoConIva = 0;
            montoConIva = Convert.ToInt32(montoNeto * Convert.ToDecimal(1.19));
            return montoConIva;
        }

        public Decimal getMontoSinIva(decimal montoBruto)
        {
            Decimal montoSinIva = 0;
            montoSinIva = Convert.ToDecimal(montoBruto / Convert.ToDecimal(1.19));
            montoSinIva = Decimal.Round(montoSinIva, 4);
            return montoSinIva;
        }
        public static bool ValidaRut(string rut)
        {
            rut = rut.Replace(".", "").ToUpper();
            Regex expresion = new Regex("^([0-9]+-[0-9K])$");
            string dv = rut.Substring(rut.Length - 1, 1);
            if (!expresion.IsMatch(rut))
            {
                return false;
            }
            char[] charCorte = { '-' };
            string[] rutTemp = rut.Split(charCorte);
            if (dv != Digito(int.Parse(rutTemp[0])))
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Método que valida el rut con el digito verificador
        /// por separado
        /// </summary>
        /// <param name="rut">integer</param>
        /// <param name="dv">char</param>
        /// <returns>booleano</returns>
        public static bool ValidaRut(string rut, string dv)
        {
            return ValidaRut(rut + "-" + dv);
        }
        /// <summary>
        /// método que calcula el digito verificador a partir
        /// de la mantisa del rut
        /// </summary>
        /// <param name="rut"></param>
        /// <returns></returns>
        public static string Digito(int rut)
        {
            int suma = 0;
            int multiplicador = 1;
            while (rut != 0)
            {
                multiplicador++;
                if (multiplicador == 8)
                    multiplicador = 2;
                suma += (rut % 10) * multiplicador;
                rut = rut / 10;
            }
            suma = 11 - (suma % 11);
            if (suma == 11)
            {
                return "0";
            }
            else if (suma == 10)
            {
                return "K";
            }
            else
            {
                return suma.ToString();
            }
        }

        public string getConfgRegi()
        {
            string estado = "True";
            CultureInfo culture = CultureInfo.CurrentCulture;
            if (culture.NumberFormat.NumberGroupSeparator != "," || culture.NumberFormat.NumberDecimalSeparator != ".")
            {
                estado = "False";
            }

            return estado;
            //Console.WriteLine("Simbolo Decimal {0} - Separador de miles:  [{1}]",
            //                  culture.NumberFormat.NumberDecimalSeparator, culture.NumberFormat.NumberGroupSeparator);
        }

    }
}
