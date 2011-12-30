using System;

namespace Tutorial.Aspects.Intro
{
    public abstract class LoggingDecorator
    {
        private readonly ILogger _logger;

        protected LoggingDecorator(ILogger logger)
        {
            _logger = logger;
        }

        protected void Log(string methodName, Action methodBody)
        {
            try
            {
                _logger.Debug(methodName + "():  OnBegin");
                methodBody();
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
