using System;
using Castle.MicroKernel;
using Castle.MicroKernel.Registration;
using Tutorial.Aspects.Intro.Domain;

namespace Tutorial.Aspects.Intro.IoC
{
    public class AnotherExampleRegistration : IRegistration
    {
        public void Register(IKernelInternal kernel)
        {
            kernel.Register(Component.For<IAnotherExample>().ImplementedBy<AnotherExample>());
        }
    }
}
