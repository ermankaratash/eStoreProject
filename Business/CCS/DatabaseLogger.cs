using System;

namespace Business.CCS
{
    public class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("It is logged on database");
        }
    }
}
