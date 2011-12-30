using System;
using Castle.Core;
using Tutorial.Aspects.Intro.Interception;

namespace Tutorial.Aspects.Intro
{
    [Interceptor(typeof(LoggingAspect))]
    public class Example : IExample
    {
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
