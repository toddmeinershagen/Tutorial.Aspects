namespace Tutorial.Aspects.Intro
{
    public class LoggedExample : LoggingDecorator, IExample
    {
        private readonly IExample _example;

        public LoggedExample(ILogger logger, IExample example)
            : base(logger)
        {
            _example = example;
        }

        //NOTES:  
        //
        //  1.  Allows us to achieve SoC and centralize the logging logic in a base decorator class.
        //  2.  Requires each class to have an interface and its own decorator to wrap functionality.
        //  3.  Still requires instruction/peer review to ensure adherence to standard.
        //
        public void MethodOne()
        {
            Log("MethodOne", () => _example.MethodOne());
        }

        public void MethodTwo()
        {
            Log("MethodTwo", () => _example.MethodTwo());
        }
    }
}
