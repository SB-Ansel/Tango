using NLog;
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
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        const int INTERVAL = 5 * 1000; // ms
        bool isDebug = false;

        public Main(bool debug = false)
        {
            if (debug) toggleDebug();
            Logger.Info("Contructing the service...");
        }

        ~Main()
        {
            Logger.Info("Contructing the service...");
        }

        public void OnStart()
        {
            Logger.Info("Starting the service...");

            OnTick();
        }

        public void OnStop()
        {
            Logger.Info("Stopping the service...");

        }

        public void OnTick()
        {
            Logger.Debug("Tick!");

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

        void toggleDebug()
        {
            isDebug = !isDebug;

            LogManager.Configuration.Variables["myLevel"] = isDebug ? "Debug" : "Info";
            LogManager.ReconfigExistingLoggers();
        }

    }
}
