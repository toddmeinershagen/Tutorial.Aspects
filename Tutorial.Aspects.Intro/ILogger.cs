using System;

namespace Tutorial.Aspects.Intro
{
    public interface ILogger
    {
        void Debug(string message);
        void Error(string message, Exception exception);
    }
}
