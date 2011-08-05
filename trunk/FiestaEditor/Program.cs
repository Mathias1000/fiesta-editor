using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using FiestaLib;
using System.IO;

using Microsoft.VisualBasic.ApplicationServices;

namespace FiestaEditor
{
    static class Program
    {
        public static Config AppConfig { get; set; }
        private static MyWindowsApplicationBase appBase;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            MessageBox.Show("1");
            Log.writer = new StreamWriter(File.Open(AppPath + "\\log.txt", FileMode.Append, FileAccess.Write, FileShare.ReadWrite));
            LoadConfig(AppPath + "\\config.xml");
            MessageBox.Show("4");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MessageBox.Show("2");
            appBase = new MyWindowsApplicationBase();

            MessageBox.Show("3");
            // <1> Set the StartupNextInstance event handler.
            appBase.StartupNextInstance += new StartupNextInstanceEventHandler(appBase_StartupNextInstance);

            MessageBox.Show("5");
            appBase.Run(args);
        }

        static void appBase_StartupNextInstance(object sender, StartupNextInstanceEventArgs e)
        {
            MessageBox.Show("6");
            if (e.CommandLine.Count != 0)
            {
                appBase.GetMainForm().OpenNewTab(e.CommandLine[0]);
                MessageBox.Show("7");
            }
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

    // This should all be refactored to make it less tightly-coupled, obviously.
    class MyWindowsApplicationBase : WindowsFormsApplicationBase
    {
        internal MyWindowsApplicationBase()
            : base()
        {
            // This is a single instance application.
            this.IsSingleInstance = true;

            // Set to the instance of your form to run.
            this.MainForm = new MainForm();
        }

        public MainForm GetMainForm()
        {
            return this.MainForm as MainForm;
        }
    }

}
