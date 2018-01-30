using System;
using JCSystem.Core.Vlc.Interops.Signatures.libvlc.h;

namespace JCSystem.Core.Vlc.Interops
{
    public sealed partial class VlcManager
    {
        public void ReleaseInstance(VlcInstance instance)
        {
            if (instance == IntPtr.Zero)
                return;
            GetInteropDelegate<ReleaseInstance>().Invoke(instance);
        }
    }
}
