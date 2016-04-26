using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;

namespace DanskateAnnouncer
{
    class AnnouncerUi
    {
        [STAThread]
        public static void ThreadProc()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Instead of running a form, we run an ApplicationContext.
            Application.Run(new AnnouncerContext());
        }
    }
}
