using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using FiestaLib;
using System.IO;

namespace FiestaEditor
{
    static class Program
    {
        public static Config AppConfig { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Log.writer = new StreamWriter(AppPath + "\\log.txt", true);
            LoadConfig(AppPath + "\\config.xml");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public static string AppPath
        {
            get
            {
                return Path.GetDirectoryName(Application.ExecutablePath);
            }
        }

        public static void LoadConfig(string path)
        {
            try
            {
                AppConfig = Config.Load(path);
                if (AppConfig == null)
                {
                    AppConfig = new Config()
                    {
                        FileEncoding = "utf8"
                    };
                    AppConfig.Save(path);
                }
                SHNFile.Encoding = AppConfig.GetEncoding();
            }
            catch (Exception ex)
            {
                Log.Exception(ex);
            }
        }
    }
}
