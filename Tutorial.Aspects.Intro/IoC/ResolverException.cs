using System;

namespace Tutorial.Aspects.Intro.IoC
{
    public class ResolverException : Exception
    {
        public ResolverException(Type type, Exception ex)
            : base(string.Format("Resolution of type '{0}' failed.", type.FullName), ex)
        { }
    }
}
