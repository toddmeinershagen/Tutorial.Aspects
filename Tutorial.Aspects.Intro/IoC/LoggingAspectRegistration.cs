using Castle.MicroKernel;
using Castle.MicroKernel.Registration;
using Tutorial.Aspects.Intro.Interception;

namespace Tutorial.Aspects.Intro.IoC
{
    public class LoggingAspectRegistration : IRegistration
    {
        public void Register(IKernelInternal kernel)
        {
            kernel.Register(Component.For<LoggingAspect>().ImplementedBy<LoggingAspect>());
        }
    }
}
