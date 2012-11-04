using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ChromiumEngine;

namespace Cheetah
{
    static class Program
    {
        public static AutoCompleteStringCollection autocompletedata;
        public static string GetCheetahFolder()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments) + @"\Cheetah\";
        }
        ///<summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Directory.Exists(GetCheetahFolder()) == false)
                Directory.CreateDirectory(GetCheetahFolder());
            WebConfig conf = WebConfig.Default;
#if DEBUG
            conf.LogFile = Application.StartupPath + @"\log.txt";
            conf.LogSeverity = ChromiumEngine.Enum.LogSeverity.Verbose;
#endif
            if (Directory.Exists(GetCheetahFolder() + @"\Cache\") == false)
                Directory.CreateDirectory(GetCheetahFolder() + @"\Cache\");
            conf.CachePath = GetCheetahFolder() + @"\Cache\";
            WebCore.Initialize(conf);
            History.initialize();
            Bookmarking.initialize();
            autocompletedata = new AutoCompleteStringCollection();
            for (int i = 0; i < History.GetItemsCount() - 1; i++)
                autocompletedata.Add(History.Url(i));
            for (int i = 0; i < Bookmarking.GetItemsCount() - 1; i++)
                autocompletedata.Add(Bookmarking.Url(i));
            AuthenticationPasswords.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new Form1());
            WebCore.ShutDown();
        }
    }
}
