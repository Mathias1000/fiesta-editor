using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace FiestaEditor
{
    public class Config
    {
        public string FileEncoding { get; set; }
        public Config()
        {

        }

        public void Save(string path)
        {
            using (FileStream file = File.Create(path))
            {
                XmlSerializer ser = new XmlSerializer(typeof(Config));
                ser.Serialize(file, this);
            }
        }

        public Encoding GetEncoding()
        {
            return GetEncodingByName(this.FileEncoding);
        }

        public static string GetEncodingName(Encoding enc)
        {
            if (enc == Encoding.ASCII)
                return "ascii";
            if (enc == Encoding.BigEndianUnicode)
                return "bigendianunicode";
            if (enc == Encoding.Unicode)
                return "unicode";
            if (enc == Encoding.UTF32)
                return "utf32";
            if (enc == Encoding.UTF7)
                return "utf7";
            if (enc == Encoding.UTF8)
                return "utf8";
            return "null";
        }

        public static Encoding GetEncodingByName(string name)
        {
            switch (name.ToLower())
            {
                case "ascii":
                    return Encoding.ASCII;
                case "bigendianunicode":
                    return Encoding.BigEndianUnicode;
                case "unicode":
                    return Encoding.Unicode;
                case "uft32":
                    return Encoding.UTF32;
                case "utf7":
                    return Encoding.UTF7;
                case "utf8":
                    return Encoding.UTF8;
                default:
                    return Encoding.ASCII;
            }
        }

        public static Config Load(string path)
        {
            if (!File.Exists(path)) return null;
            Config conf;
            using (FileStream file = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                XmlSerializer ser = new XmlSerializer(typeof(Config));
                conf = (Config)ser.Deserialize(file);
            }
            return conf;
        }
    }
}
