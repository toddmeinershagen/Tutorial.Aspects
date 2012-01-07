using System;
using Castle.DynamicProxy;
using Tutorial.Aspects.Intro.Domain;

namespace Tutorial.Aspects.Intro.Interception
{
    public class LoggingAspect : BaseInterceptor
    {
        readonly ILogger _logger;

        public LoggingAspect(ILogger logger)
        {
            _logger = logger;
        }

        protected override void OnBefore(IInvocation invocation, bool proceed)
        {
            var methodName = invocation.Method.Name;
            _logger.Debug(methodName + "():  OnBegin");
        }

        protected override void OnAfterThrowing(IInvocation invocation, Exception ex)
        {
            var methodName = invocation.Method.Name;
            _logger.Error(methodName + "():  OnException", ex);
        }

        protected override void OnAfter(IInvocation invocation)
        {
            var methodName = invocation.Method.Name;
            _logger.Debug(methodName + "():  OnEnd");
        }
    }
}
