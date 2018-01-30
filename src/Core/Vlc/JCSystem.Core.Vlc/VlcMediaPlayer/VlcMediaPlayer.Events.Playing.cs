using System;
using JCSystem.Core.Vlc.Interops.Signatures.libvlc.h;

namespace JCSystem.Core.Vlc
{
    public sealed partial class VlcMediaPlayer
    {
        private EventCallback myOnMediaPlayerPlayingInternalEventCallback;
        public event EventHandler<VlcMediaPlayerPlayingEventArgs> Playing;

        private void OnMediaPlayerPlayingInternal(IntPtr ptr)
        {
            OnMediaPlayerPlaying();
        }

        public void OnMediaPlayerPlaying()
        {
            var del = Playing;
            if (del != null)
                del(this, new VlcMediaPlayerPlayingEventArgs());
        }
    }
}