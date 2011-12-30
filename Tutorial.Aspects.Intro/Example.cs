using System;

namespace Tutorial.Aspects.Intro
{
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
