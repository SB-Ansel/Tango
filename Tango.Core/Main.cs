using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tango.Core
{
    public class Main
    {
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

        }

        public void OnStop()
        {
            Console.WriteLine("Stopping the service...");

        }

    }
}
