using System;
using System.Collections.Generic;
using System.Threading;

namespace DanskateAnnouncer
{
    static class main
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            Thread t = new Thread(new ThreadStart(AnnouncerUi.ThreadProc));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
        }
    }
}