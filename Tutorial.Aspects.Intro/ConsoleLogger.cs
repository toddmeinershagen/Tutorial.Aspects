using System;

namespace Tutorial.Aspects.Intro
{
    public class ConsoleLogger : ILogger
    {
        public void Debug(string message)
        {
            Console.WriteLine("Debug:  " + message);
        }

        public void Error(string message, Exception exception)
        {
            Console.WriteLine("Error:  " + message);
        }
    }
}
