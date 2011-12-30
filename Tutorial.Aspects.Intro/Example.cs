using System;

namespace Tutorial.Aspects.Intro
{
    public class Example
    {
        readonly ILogger _logger;

        public Example(ILogger logger)
        {
            _logger = logger;
        }

        public void MethodOne()
        {
            try
            {
                _logger.Debug("MethodOne():  OnBegin");
                Console.WriteLine("MethodOne():  Implementation");
            }
            catch (Exception ex)
            {
                _logger.Error("MethodOne():  OnException", ex);
            }
            finally
            {
                _logger.Debug("MethodOne():  OnEnd");
            }
        }

        public void MethodTwo()
        {
            try
            {
                _logger.Debug("MethodTwo():  OnBegin");
                Console.WriteLine("MethodTwo():  Implementation");
            }
            catch (Exception ex)
            {
                _logger.Error("MethodTwo():  OnException", ex);
            }
            finally
            {
                _logger.Debug("MethodTwo():  OnEnd");
            }
        }
    }
}
