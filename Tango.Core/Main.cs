using System;
using System.Collections.Generic;
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

    }
}
