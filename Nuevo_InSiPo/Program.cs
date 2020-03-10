using Nuevo_InSiPo.Interfaces;
using System;
using System.Windows.Forms;

namespace Nuevo_InSiPo
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frBienvenida());
        }
    }
}
