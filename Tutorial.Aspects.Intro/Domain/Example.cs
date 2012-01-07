using System;
using Tutorial.Aspects.Intro.ILWeaving;

namespace Tutorial.Aspects.Intro.Domain
{
    public class Example : IExample
    {
        public void MethodOne()
        {
            Console.WriteLine("MethodOne():  Implementation");
        }

        [LoggingAspect]
        public void MethodTwo()
        {
            Console.WriteLine("MethodTwo():  Implementation");
        }
    }
}
