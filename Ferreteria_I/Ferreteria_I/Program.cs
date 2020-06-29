using System;
using System.Windows.Forms;
using Ferreteria_I.Model;
using Ferreteria_I.Views;

namespace Ferreteria_I
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Venta_V());
        }
    }
}
