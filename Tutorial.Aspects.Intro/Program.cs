using System;
using Tutorial.Aspects.Intro.Domain;
using Tutorial.Aspects.Intro.IoC;

namespace Tutorial.Aspects.Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Resolver.Initialize();

            var example = Resolver.ResolveFor<IExample>();
            example.MethodOne();
            example.MethodTwo();

            var anotherExample = Resolver.ResolveFor<IAnotherExample>();
            anotherExample.MethodThree();

            Console.ReadLine();
        }
    }
}
