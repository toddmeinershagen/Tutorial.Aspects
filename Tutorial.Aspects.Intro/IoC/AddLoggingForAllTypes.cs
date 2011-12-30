using Castle.Core;
using Castle.MicroKernel;
using Castle.MicroKernel.ModelBuilder;
using Tutorial.Aspects.Intro.Interception;

namespace Tutorial.Aspects.Intro.IoC
{
    class AddLoggingForAllTypes : IContributeComponentModelConstruction
    {
        public void ProcessModel(IKernel kernel, ComponentModel model)
        {
            model.Interceptors.Add(InterceptorReference.ForType(typeof(LoggingAspect)));
        }
    }
}
