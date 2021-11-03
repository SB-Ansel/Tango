using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tango.Core
{
    public class Main
    {
        const int INTERVAL = 5 * 1000; // ms

        public Main()
        {
            Console.WriteLine("Contructing the service...");
        }

        ~Main()
        {
            Console.WriteLine("Contructing the service...");
        }

        public void OnStart()
        {
            Console.WriteLine("Starting the service...");

            OnTick();
        }

        public void OnStop()
        {
            Console.WriteLine("Stopping the service...");

        }

        public void OnTick()
        {
            Console.WriteLine("Tick!");

            Thread.Sleep(INTERVAL);
            OnTick();
        }


        static void LaunchDelProf()
        {
            // Use ProcessStartInfo class
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "C:\\Windows\\DelProf2.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.Arguments = "/q /d:5 ";

            try
            {
                // Start the process with the info we specified.
                // Call WaitForExit and then the using statement will close.
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not launch the DelProf2: " + ex.Message);
            }
        }

    }
}
