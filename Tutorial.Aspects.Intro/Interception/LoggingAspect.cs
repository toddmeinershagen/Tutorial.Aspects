using System;
using Castle.DynamicProxy;

namespace Tutorial.Aspects.Intro.Interception
{
    public class LoggingAspect : IInterceptor
    {
        readonly ILogger _logger;

        public LoggingAspect(ILogger logger)
        {
            _logger = logger;
        }

        public void Intercept(IInvocation invocation)
        {
            var methodName = invocation.Method.Name;

            try
            {
                _logger.Debug(methodName + "():  OnBegin");
                invocation.Proceed();
            }
            catch (Exception ex)
            {
                _logger.Error(methodName + "():  OnException", ex);
            }
            finally
            {
                _logger.Debug(methodName + "():  OnEnd");
            }
        }
    }
}
