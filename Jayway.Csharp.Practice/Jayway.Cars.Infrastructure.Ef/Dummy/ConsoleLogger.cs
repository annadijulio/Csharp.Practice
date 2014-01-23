using System;

namespace Jayway.Cars.Infrastructure.Ef.Dummy
{
    public class ConsoleLogger : ILogger
    {
        public void Information(string message)
        {
            Console.WriteLine(message);
        }
    }
}