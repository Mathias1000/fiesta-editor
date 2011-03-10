using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FiestaEditor
{
    public static class Log
    {
        public static TextWriter writer;
        public static void Append(string text, params string[] par)
        {
            writer.Write(DateTime.Now.ToShortDateString() + " ");
            writer.WriteLine(text, par);
            writer.Flush();
        }

        public static void Exception(Exception ex)
        {
            Append("Error: {0} -- Stack: {1}", ex.Message, ex.StackTrace);
        }
    }
}
