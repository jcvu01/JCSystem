using System;
using JCSystem.Core.Vlc.Interops.Signatures.libvlc.h;

namespace JCSystem.Core.Vlc
{
    public partial class VlcMedia
    {
        private EventCallback myOnMediaFreedInternalEventCallback;
        public event EventHandler<VlcMediaFreedEventArgs> Freed;

        private void OnMediaFreedInternal(IntPtr ptr)
        {
            OnMediaFreed();
        }

        public void OnMediaFreed()
        {
            Freed?.Invoke(this, new VlcMediaFreedEventArgs());
        }
    }
}