using System;
using System.Diagnostics;

namespace da
{
    class ProcessMonitorSample
    {
        public static void Main()
        { 
            using (Process myProcess = Process.Start("NotePad.exe"))
            {
                do
                {
                    if (!myProcess.HasExited)
                    {
     
                        myProcess.Refresh();

                        Console.WriteLine();

                        Console.WriteLine($"{myProcess} -");
                        Console.WriteLine("-------------------------------------");

                        Console.WriteLine($"  Physical memory usage     : {myProcess.WorkingSet64}");
                        Console.WriteLine($"  Base priority             : {myProcess.BasePriority}");
                        Console.WriteLine($"  Priority class            : {myProcess.PriorityClass}");
                        Console.WriteLine($"  User processor time       : {myProcess.UserProcessorTime}");
                        Console.WriteLine($"  Privileged processor time : {myProcess.PrivilegedProcessorTime}");
                        Console.WriteLine($"  Total processor time      : {myProcess.TotalProcessorTime}");
                        Console.WriteLine($"  Paged system memory size  : {myProcess.PagedSystemMemorySize64}");
                        Console.WriteLine($"  Paged memory size         : {myProcess.PagedMemorySize64}");

                    }
                }
                while (!myProcess.WaitForExit(1000));

            }
        }
    }
}