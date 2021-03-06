﻿using System;
using System.Runtime.InteropServices;
using JCSystem.Core.Vlc.Interops.Signatures.libvlc.h;
using JCSystem.Core.Vlc.Interops.Signatures.libvlc_events.h;

namespace JCSystem.Core.Vlc
{
    public sealed partial class VlcMediaPlayer
    {
        private EventCallback myOnMediaPlayerVideoOutChangedInternalEventCallback;
        public event EventHandler<VlcMediaPlayerVideoOutChangedEventArgs> VideoOutChanged;

        private void OnMediaPlayerVideoOutChangedInternal(IntPtr ptr)
        {
#if NET20 || NET35 || NET40 || NET45
            var args = (VlcEventArg)Marshal.PtrToStructure(ptr, typeof(VlcEventArg));
#else
            var args = Marshal.PtrToStructure<VlcEventArg>(ptr);
#endif
            OnMediaPlayerVideoOutChanged(args.eventArgsUnion.MediaPlayerVideoOutChanged.NewCount);
        }

        public void OnMediaPlayerVideoOutChanged(int newCount)
        {
            var del = VideoOutChanged;
            if (del != null)
                del(this, new VlcMediaPlayerVideoOutChangedEventArgs(newCount));
        }
    }
}