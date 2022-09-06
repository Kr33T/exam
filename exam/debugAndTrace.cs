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
        public static void debugAction(string str)
        {
            Trace.Listeners.Add(new TextWriterTraceListener("debug.txt"));
            Debug.WriteLine(str);
            Trace.Flush();
        }
    }
}
