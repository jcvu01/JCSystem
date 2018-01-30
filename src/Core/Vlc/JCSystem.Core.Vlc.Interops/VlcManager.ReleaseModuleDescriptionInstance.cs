using System;
using JCSystem.Core.Vlc.Interops.Signatures.libvlc.h;

namespace JCSystem.Core.Vlc.Interops
{
    public sealed partial class VlcManager
    {
        public void ReleaseModuleDescriptionInstance(IntPtr moduleDescriptionInstance)
        {
            GetInteropDelegate<ReleaseModuleDescription>().Invoke(moduleDescriptionInstance);
        }
    }
}
