using SIPP.controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIPP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Connection connection = new Connection();
            try
            {
                connection.OpenConection();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new SIPP());
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message,"Aplikasi Gagal Dijalankan");
                Application.Exit();
            }
        }
    }
}
