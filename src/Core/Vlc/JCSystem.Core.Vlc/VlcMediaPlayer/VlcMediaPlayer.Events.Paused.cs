using System;
using JCSystem.Core.Vlc.Interops.Signatures.libvlc.h;

namespace JCSystem.Core.Vlc
{
    public sealed partial class VlcMediaPlayer
    {
        private EventCallback myOnMediaPlayerPausedInternalEventCallback;
        public event EventHandler<VlcMediaPlayerPausedEventArgs> Paused;

        private void OnMediaPlayerPausedInternal(IntPtr ptr)
        {
            OnMediaPlayerPaused();
        }

        public void OnMediaPlayerPaused()
        {
            var del = Paused;
            if (del != null)
                del(this, new VlcMediaPlayerPausedEventArgs());
        }
    }
}