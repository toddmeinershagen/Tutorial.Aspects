using Castle.MicroKernel;
using Castle.MicroKernel.Registration;

namespace Tutorial.Aspects.Intro.IoC
{
    public class ExampleRegistration : IRegistration
    {
        public void Register(IKernelInternal kernel)
        {
            kernel.Register(
                Component.For<IExample>().ImplementedBy<LoggedExample>(),
                Component.For<IExample>().ImplementedBy<Example>());
        }
    }
}
