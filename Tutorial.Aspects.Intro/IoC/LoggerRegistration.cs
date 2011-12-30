using Castle.MicroKernel;
using Castle.MicroKernel.Registration;
using Tutorial.Aspects.Intro.Domain;
using Tutorial.Aspects.Intro.Infrastructure;

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
