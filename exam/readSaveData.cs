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
        /// <summary>
        /// Необходим для записи строки в файл
        /// </summary>
        public static void Save(string str)
        {
            sw.WriteLine(str);
        }
        /// <summary>
        /// Необходим для закрытия streamWriter
        /// </summary>
        public static void onEnd()
        {
            sw.Close();
        }
    }
}
