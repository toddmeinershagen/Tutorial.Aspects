using Castle.MicroKernel;
using Castle.MicroKernel.Registration;

namespace Tutorial.Aspects.Intro.IoC
{
    public class AddLoggingForAllTypesRegistration : IRegistration
    {
        public void Register(IKernelInternal kernel)
        {
            kernel.ComponentModelBuilder.AddContributor(new AddLoggingForAllTypes());
        }
    }
}
