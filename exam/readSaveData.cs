using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace exam
{
    internal class readSaveData
    {
        public static StreamWriter sw = null;
        /// <summary>
        /// Удаляет файл, потом создает новый
        /// </summary>
        public static void onStart(string path)
        {
            File.Delete(path);
            sw = new StreamWriter(path);
        }

        public static void Save(string str)
        {
            sw.WriteLine(str);
        }

        public static void onEnd()
        {
            sw.Close();
        }
    }
}
