using System;
using Tutorial.Aspects.Intro.ILWeaving;

namespace Tutorial.Aspects.Intro
{
    public class AnotherExample : IAnotherExample
    {
        [LoggingAspect]
        public void MethodThree()
        {
            Console.WriteLine("MethodThree():  Implementation");
        }
    }
}
