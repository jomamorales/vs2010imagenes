using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Helpers;

namespace MyProject
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

            Login login = new Login();
            login.ShowDialog();

            if (login.DialogResult == DialogResult.OK)
            {
                login.Close();
                Application.Run(new Principal1());
            }
        }
    }
}
