using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Management.Automation;
using System.Threading;
using System.Linq;

namespace ExecutePowershell
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> processesToKill = new List<string>();

            processesToKill.Add("Chrome");

            var processes = Process.GetProcesses();

            foreach (var item in processes)
            {
                if (processesToKill.Any(x => x == item.ProcessName))
                {
                    Console.WriteLine("Killing... " + item.ProcessName);
                }
            }
        }
    }
}
