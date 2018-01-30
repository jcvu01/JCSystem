using System;
using JCSystem.Core.Vlc.Interops.Signatures.libvlc.h;

namespace JCSystem.Core.Vlc.Interops
{
    public sealed partial class VlcManager
    {
        /// <summary>
        /// Keeps a reference to the last callback that was given to the <see cref="SetLog"/> method.
        /// This is to avoid garbage collection of the delegate before the function is called.
        /// </summary>
        private LogCallback logCallbackReference;

        public void SetLog(LogCallback callback)
        {
            if (callback == null)
            {
                throw new ArgumentException("Callback for log is not initialized.");
            }

            EnsureVlcInstance();

            logCallbackReference = callback;
            GetInteropDelegate<SetLog>().Invoke(myVlcInstance, logCallbackReference, IntPtr.Zero);
        }
    }
}
