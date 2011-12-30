using System;
using Castle.Core;
using Tutorial.Aspects.Intro.Interception;

namespace Tutorial.Aspects.Intro
{
    [Interceptor(typeof(LoggingAspect))]
    public class AnotherExample : IAnotherExample
    {
        public void MethodThree()
        {
            Console.WriteLine("MethodThree():  Implementation");
        }
    }
}
