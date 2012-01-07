using System;
using PostSharp.Aspects;
using PostSharp.Extensibility;
using Tutorial.Aspects.Intro.Domain;
using Tutorial.Aspects.Intro.IoC;

namespace Tutorial.Aspects.Intro.ILWeaving
{
    [Serializable]
    [MulticastAttributeUsage(
        MulticastTargets.Method, 
        TargetMemberAttributes = MulticastAttributes.Instance
    )]
    public class LoggingAspect : OnMethodBoundaryAspect
    {
        private ILogger _logger;

        public override void OnEntry(MethodExecutionArgs args)
        {
            Logger.Debug(args.Method.Name + "():  OnBegin");
        }

        public override void OnException(MethodExecutionArgs args)
        {
            Logger.Error(args.Method.Name + "():  OnException", args.Exception);
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            Logger.Debug(args.Method.Name + "():  OnEnd");
        }

        public ILogger Logger
        {
            get
            {
                if (_logger == null)
                    _logger = Resolver.ResolveFor<ILogger>();

                return _logger;
            }
        }
    }
}
