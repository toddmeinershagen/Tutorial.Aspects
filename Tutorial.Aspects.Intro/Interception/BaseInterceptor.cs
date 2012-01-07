using System;
using Castle.DynamicProxy;

namespace Tutorial.Aspects.Intro.Interception
{
    public abstract class BaseInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            bool proceed = true;
            OnBefore(invocation, proceed);

            try
            {
                if (proceed)
                    invocation.Proceed();
                OnAfterReturning(invocation);
            }
            catch (Exception ex)
            {
                OnAfterThrowing(invocation, ex);
                throw;
            }
            finally
            {
                OnAfter(invocation);
            }
        }

        protected virtual void OnBefore(IInvocation invocation, bool proceed)
        { }

        protected virtual void OnAfter(IInvocation invocation)
        { }

        protected virtual void OnAfterReturning(IInvocation invocation)
        { }

        protected virtual void OnAfterThrowing(IInvocation invocation, Exception ex)
        { }
    }
}
