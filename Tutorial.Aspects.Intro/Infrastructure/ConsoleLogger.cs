using System;
using Tutorial.Aspects.Intro.Domain;
using Tutorial.Aspects.Intro.ILWeaving;

namespace Tutorial.Aspects.Intro.Infrastructure
{
    [LoggingAspect(AttributeExclude = true)]
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
