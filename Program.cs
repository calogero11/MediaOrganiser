using System;
using System.Windows.Forms;
using MediaOrganiser.Interfaces;
using MediaOrganiser.Services;

namespace MediaOrganiser
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
            IViewService viewService = new ViewService();
            Application.Run(new MainForm(viewService));
        }
    }
}