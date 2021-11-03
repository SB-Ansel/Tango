using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tango.Tester
{
    class Program
    {
        static Tango.Core.Main tangoCore;
        static void Main(string[] args)
        {
            tangoCore = new Tango.Core.Main(debug:true);

            tangoCore.OnStart();

            /* 
             * Logic goes here
             * 
             */

            tangoCore.OnStop();
        }
    }
}
