using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Tango.Service
{
    public partial class Service : ServiceBase
    {
        Tango.Core.Main tangoCore;

        public Service()
        {
            InitializeComponent();
            tangoCore = new Tango.Core.Main();
        }

        protected override void OnStart(string[] args)
        {
            tangoCore.OnStart();
        }

        protected override void OnStop()
        {
            tangoCore.OnStop();
        }
    }
}
