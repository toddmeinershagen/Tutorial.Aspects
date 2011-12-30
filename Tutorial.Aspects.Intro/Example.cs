using System;
using Tutorial.Aspects.Intro.ILWeaving;

namespace Tutorial.Aspects.Intro
{
    public class Example : IExample
    {
        [LoggingAspect]
        public void MethodOne()
        {
            Console.WriteLine("MethodOne():  Implementation");
        }

        public void MethodTwo()
        {
            Console.WriteLine("MethodTwo():  Implementation");
        }
    }
}
