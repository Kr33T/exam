using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace exam
{
    internal class debugAndTrace
    {
        /// <summary>
        /// Добавление слушателя
        /// </summary>
        public static void onStart()
        {
            Trace.Listeners.Add(new TextWriterTraceListener("debug.txt"));
        }
        /// <summary>
        /// Запись действия в файл дэбага
        /// </summary>
        public static void debugAction(string str)
        {
            Debug.WriteLine(str);
            Trace.Flush();
        }
    }
}
