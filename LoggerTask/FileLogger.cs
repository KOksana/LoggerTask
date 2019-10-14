using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerTask
{
    class FileLogger : ILogger
    {
        private string _path = "C:\\testLog\\LogFile.txt";
        DateFormat dateFormat = DateFormat.DateTimeLocal;

        public FileLogger() { }

        public FileLogger(string path)
        {
            _path = path;
        }

        public void Log(string message)
        {
            Log(message, _path);
        }

        public void Log(string message, string path)
        {
           using (System.IO.StreamWriter file = new System.IO.StreamWriter(path, true))
            {
                file.WriteLine(GetCurrentTime() + ": " + message);
            }
        }

        public void SetDateFormat(DateFormat dateFormat)
        {
            this.dateFormat = dateFormat;
        }

        private string GetCurrentTime()
        {
            if (dateFormat == DateFormat.DateTimeLocal)
                return DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
            else
                return DateTime.UtcNow.ToString();
        }
    }
}
