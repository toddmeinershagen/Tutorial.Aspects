﻿using Castle.MicroKernel;
using Castle.MicroKernel.Registration;

namespace Tutorial.Aspects.Intro.IoC
{
    public class LoggerRegistration : IRegistration
    {
        public void Register(IKernelInternal kernel)
        {
            kernel.Register(Component.For<ILogger>().ImplementedBy<ConsoleLogger>());
        }
    }
}
