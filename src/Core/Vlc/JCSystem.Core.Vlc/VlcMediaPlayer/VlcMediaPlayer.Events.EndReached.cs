using System;
using JCSystem.Core.Vlc.Interops.Signatures.libvlc.h;

namespace JCSystem.Core.Vlc
{
    public sealed partial class VlcMediaPlayer
    {
        private EventCallback myOnMediaPlayerEndReachedInternalEventCallback;
        public event EventHandler<VlcMediaPlayerEndReachedEventArgs> EndReached;

        private void OnMediaPlayerEndReachedInternal(IntPtr ptr)
        {
            OnMediaPlayerEndReached();
        }

        public void OnMediaPlayerEndReached()
        {
            var del = EndReached;
            if (del != null)
                del(this, new VlcMediaPlayerEndReachedEventArgs());
        }
    }
}
