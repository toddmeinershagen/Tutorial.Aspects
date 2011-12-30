using System;
using Castle.Windsor;

namespace Tutorial.Aspects.Intro.IoC
{
    public class Resolver
    {
        private static IWindsorContainer _container;

        public static void Initialize()
        {
            _container = new WindsorContainer();
            _container.Register(new LoggerRegistration());
            _container.Register(new ExampleRegistration());
        }

        public static T ResolveFor<T>()
        {
            try
            {
                return _container.Resolve<T>();
            }
            catch (Exception ex)
            {
                throw new ResolverException(typeof(T), ex);
            }
        }
    }
}
