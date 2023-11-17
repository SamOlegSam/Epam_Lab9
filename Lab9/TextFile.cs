using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.Win32;

namespace Lab9
{
    static public class TextFile
    {
        public static string OpenFile(string str)
        {
            string strfile = File.ReadAllText(str);
            return strfile;
        }

        public static string SaveFile(string str, string Path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(Path, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(str);
                    sw.WriteLine(Path);

                }
                return "запись заершена успешно!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
