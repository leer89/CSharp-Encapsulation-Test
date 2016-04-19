using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            OpenPSL(@"G:\JOBS\60054D\PSL_AGEIN\PSL_AGEIN.ppr");
        }
        static void OpenPSL(string file)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"C:\Program Files (x86)\Psl\bin\pslDev.exe";
            startInfo.Arguments = file;
            Process.Start(startInfo);
        }
    }
}
