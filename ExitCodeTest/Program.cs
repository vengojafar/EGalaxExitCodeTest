using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExitCodeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Process process = Process.Start("egalaxconsole.exe");

            process.WaitForExit();

            if (process.HasExited)
            {
                Console.WriteLine("Exit code: " + process.ExitCode);
            }

            Console.Read();
        }
    }
}
