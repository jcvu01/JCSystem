using System;
using JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h;

namespace JCSystem.Core.Vlc.Interops
{
    public sealed partial class VlcManager
    {
        public void SetMediaPlayerVideoHostHandle(VlcMediaPlayerInstance mediaPlayerInstance, IntPtr videoHostHandle)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetMediaPlayerVideoHostHandle>().Invoke(mediaPlayerInstance, videoHostHandle);
        }
    }
}
