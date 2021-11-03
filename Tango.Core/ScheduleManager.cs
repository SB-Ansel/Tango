using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tango.Core
{
    class ScheduleManager
    {
        private const string LAST_RUN_FILE_PATH = "last_run";
        private const string NEXT_RUN_FILE_PATH = "next_run";
        
        ScheduleManager()
        {
            ScheduleFile lastRun = new ScheduleFile(LAST_RUN_FILE_PATH);
            ScheduleFile nextRun = new ScheduleFile(NEXT_RUN_FILE_PATH);

        }

        public bool ShouldRun()
        {
            throw new NotImplementedException();
        }
    }


}
