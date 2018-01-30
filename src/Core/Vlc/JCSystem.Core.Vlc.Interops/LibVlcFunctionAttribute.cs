using System;

namespace JCSystem.Core.Vlc.Interops
{
    [AttributeUsage(AttributeTargets.Delegate)]
    internal sealed class LibVlcFunctionAttribute : Attribute
    {
        public string FunctionName { get; private set; }

        public LibVlcFunctionAttribute(string functionName)
        {
            FunctionName = functionName;
        }
    }
}
