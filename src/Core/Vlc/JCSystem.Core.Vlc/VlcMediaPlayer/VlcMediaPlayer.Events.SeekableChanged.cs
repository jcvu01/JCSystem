﻿using System;
using System.Runtime.InteropServices;
using JCSystem.Core.Vlc.Interops.Signatures.libvlc.h;
using JCSystem.Core.Vlc.Interops.Signatures.libvlc_events.h;

namespace JCSystem.Core.Vlc
{
    public sealed partial class VlcMediaPlayer
    {
        private EventCallback myOnMediaPlayerSeekableChangedInternalEventCallback;
        public event EventHandler<VlcMediaPlayerSeekableChangedEventArgs> SeekableChanged;

        private void OnMediaPlayerSeekableChangedInternal(IntPtr ptr)
        {
#if NET20 || NET35 || NET40 || NET45
            var args = (VlcEventArg)Marshal.PtrToStructure(ptr, typeof(VlcEventArg));
#else
            var args = Marshal.PtrToStructure<VlcEventArg>(ptr);
#endif
            OnMediaPlayerSeekableChanged(args.eventArgsUnion.MediaPlayerSeekableChanged.NewSeekable);
        }

        public void OnMediaPlayerSeekableChanged(int newSeekable)
        {
            var del = SeekableChanged;
            if (del != null)
                del(this, new VlcMediaPlayerSeekableChangedEventArgs(newSeekable));
        }
    }
}