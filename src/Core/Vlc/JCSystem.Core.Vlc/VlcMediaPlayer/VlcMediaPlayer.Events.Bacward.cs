﻿using System;
using JCSystem.Core.Vlc.Interops.Signatures.libvlc.h;

namespace JCSystem.Core.Vlc
{
	public sealed partial class VlcMediaPlayer
    {
        private EventCallback myOnMediaPlayerBackwardInternalEventCallback;
        public event EventHandler<VlcMediaPlayerBackwardEventArgs> Backward;

        private void OnMediaPlayerBackwardInternal(IntPtr ptr)
        {
            OnMediaPlayerBackward();
        }

        public void OnMediaPlayerBackward()
        {
            var del = Backward;
            if (del != null)
                del(this, new VlcMediaPlayerBackwardEventArgs());
        }
    }
}