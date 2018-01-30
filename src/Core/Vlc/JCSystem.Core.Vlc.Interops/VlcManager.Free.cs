using System;
using JCSystem.Core.Vlc.Interops.Signatures.libvlc.h;

namespace JCSystem.Core.Vlc.Interops
{
    public sealed partial class VlcManager
    {
        public void Free(IntPtr instance)
        {
            if (instance == IntPtr.Zero)
                return;
            GetInteropDelegate<Free>().Invoke(instance);
        }
    }
}
