using System;

namespace Tutorial.Aspects.Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new ConsoleLogger();
            var example = new LoggedExample(logger, new Example());

            example.MethodOne();
            example.MethodTwo();

            Console.ReadLine();
        }
    }
}
