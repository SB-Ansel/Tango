using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tango.Core
{
    class ScheduleFile
    {
        readonly string path = "";
        private DateTime creationDate = DateTime.Now;

        public ScheduleFile(string path)
        {
            this.path = path;
            creationDate = DateTime.Now;
        }

        public DateTime GetDate()
        {
            this.ReadDateFromFile();
            return creationDate;
        }

        public void SetDate(DateTime date)
        {
            this.creationDate = date;
            this.WriteDateToFile();
        }

        private void Create()
        {
            File.Create(this.path);
            File.SetAttributes(this.path, File.GetAttributes(this.path) | FileAttributes.Hidden);
        }

        private void ReadDateFromFile()
        {
            try
            {
                this.creationDate = File.GetCreationTime(this.path);
            }
            catch (FileNotFoundException)
            {
                this.Create();
                creationDate = DateTime.Now;
            }
        }

        private void WriteDateToFile()
        {
            try
            {
                File.SetCreationTime(this.path, this.creationDate);
            }
            catch (FileNotFoundException)
            {
                this.Create();
            }
        }
    }
}
