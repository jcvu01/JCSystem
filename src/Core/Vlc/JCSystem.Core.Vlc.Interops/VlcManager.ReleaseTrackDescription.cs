using System;
using JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h;

namespace JCSystem.Core.Vlc.Interops
{
    public sealed partial class VlcManager
    {
        public void ReleaseTrackDescription(IntPtr trackDescription)
        {
            GetInteropDelegate<ReleaseTrackDescription>().Invoke(trackDescription);
        }
    }
}
