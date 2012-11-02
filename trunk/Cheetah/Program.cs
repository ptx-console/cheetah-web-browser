using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ChromiumEngine;

namespace Cheetah
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            WebConfig conf = WebConfig.Default;
            conf.CachePath = Application.StartupPath + "/Cache/";
            WebCore.Initialize(conf);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            WebCore.ShutDown();
        }
    }
}
