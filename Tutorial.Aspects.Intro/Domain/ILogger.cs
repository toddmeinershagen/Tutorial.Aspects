using System;

namespace Tutorial.Aspects.Intro.Domain
{
    public interface ILogger
    {
        void Debug(string message);
        void Error(string message, Exception exception);
    }
}
