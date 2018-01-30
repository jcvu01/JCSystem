using System;
using JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h;

namespace JCSystem.Core.Vlc.Interops
{
    public sealed partial class VlcManager
    {
        public void ReleaseMediaPlayer(VlcMediaPlayerInstance mediaPlayerInstance)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                return;
            try
            {
                GetInteropDelegate<ReleaseMediaPlayer>().Invoke(mediaPlayerInstance);
            }
            finally
            {
                mediaPlayerInstance.Pointer = IntPtr.Zero;
            }
        }
    }
}
