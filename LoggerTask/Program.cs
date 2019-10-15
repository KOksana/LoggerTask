using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\testLog\\LogFile2.txt";
            FileLogger fileLogger1 = new FileLogger();
            FileLogger fileLogger2 = new FileLogger(filePath);
            ConsoleLogger consoleLogger = new ConsoleLogger();

            fileLogger2.SetDateFormat(DateFormat.UTCTime);

            fileLogger1.Log("some info");
            fileLogger2.Log("some info");
            consoleLogger.Log("some info");

            fileLogger1.Log("some info 2");
            fileLogger2.Log("some info 2");
            consoleLogger.Log("some info 2");

            Console.Read();
        }
    }
}
