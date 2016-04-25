using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DanskateAnnouncer
{
    static class main
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Instead of running a form, we run an ApplicationContext.
            Application.Run(new AnnouncerContext());
        }
    }
}