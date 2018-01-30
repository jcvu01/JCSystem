using System;
using JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h;

namespace JCSystem.Core.Vlc.Interops
{
    public sealed partial class VlcMediaPlayerInstance
    {
		public void SetVideoCallbacks(LockVideoCallback lockVideoCallback, UnlockVideoCallback unlockVideoCallback, DisplayVideoCallback displayVideoCallback, IntPtr userData)
        {
            myManager.GetInteropDelegate<SetVideoCallbacks>().Invoke(Pointer, lockVideoCallback, unlockVideoCallback, displayVideoCallback, userData);
        }
    }
}
