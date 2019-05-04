using System;
using System.Diagnostics;
using System.Linq;

namespace Priprema
{
    class Program
    {
        static void Main(string[] args)
        {
            Process p1 = new Process();
            p1.StartInfo.FileName = "notepad.exe";

            Console.WriteLine("Pokretanje procesa: notepad");
            p1.Start();

            // zaustavljanje pokrenutog procesa
            Console.WriteLine("Zaustavljanje procesa: notepad");
            Console.ReadLine();
            if (!p1.HasExited)
                p1.Kill();

          
           
            Process[] f = Process.GetProcessesByName("firefox");
            Console.WriteLine("Zaustavljanje {0} firefoxa...",
                f.Count());
            Console.ReadLine();
            foreach (Process fir in f)
                if (!fir.HasExited)
                    fir.Kill();

            // lista svih procesa na računalu
            Console.WriteLine("Lista procesa na računalu...");
            Console.ReadLine();
            Process[] sviProcesi = Process.
                GetProcesses().OrderBy(x => x.ProcessName).ToArray();
            foreach (Process proc in sviProcesi)
                Console.WriteLine("{0,-30}{1,10}{2,15}",
                    proc.ProcessName.Length > 30 ?
                       proc.ProcessName.Substring(0, 30) :
                       proc.ProcessName,
                    proc.Id, proc.WorkingSet64);



            Console.ReadLine();



        }
    }
    }

