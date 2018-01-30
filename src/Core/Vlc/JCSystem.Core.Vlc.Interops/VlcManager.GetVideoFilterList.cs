using System;
using JCSystem.Core.Vlc.Interops.Signatures.libvlc.h;

namespace JCSystem.Core.Vlc.Interops
{
    public sealed partial class VlcManager
    {
        public IntPtr GetVideoFilterList()
        {
            EnsureVlcInstance();

            return GetInteropDelegate<GetVideoFilterList>().Invoke(myVlcInstance);
        }
    }
}
