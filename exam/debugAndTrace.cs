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
        public static void onStart()
        {
            Trace.Listeners.Add(new TextWriterTraceListener("debug.txt"));
        }

        public static void debugAction(string str)
        {
            Debug.WriteLine(str);
            Trace.Flush();
        }
    }
}
