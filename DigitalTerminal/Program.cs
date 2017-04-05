using System;
using System.Windows.Forms;
using Vista;
using System.Threading;


namespace DigitalTerminal
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 


        [STAThread]
        static void Main()
        {
            bool isNew = false;
            Mutex mtx = new Mutex(true, "DigitalTerminal", out isNew);
            if (!isNew)
            {
                //MessageBox.Show("se esta ejecutando la aplicación");
                return;
            }
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmInicio());
        }


    }
}
