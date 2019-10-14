using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerTask
{
    class ConsoleLogger : ILogger
    {
        DateFormat dateFormat = DateFormat.DateTimeLocal;

        public void Log(string message)
        {
            Console.WriteLine(GetCurrentTime() + " " + message);
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
