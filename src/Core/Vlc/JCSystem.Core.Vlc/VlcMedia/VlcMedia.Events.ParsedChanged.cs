﻿using System;
using System.Runtime.InteropServices;
using JCSystem.Core.Vlc.Interops.Signatures.libvlc.h;
using JCSystem.Core.Vlc.Interops.Signatures.libvlc_events.h;

namespace JCSystem.Core.Vlc
{
    public partial class VlcMedia
    {
        private EventCallback myOnMediaParsedChangedInternalEventCallback;
        public event EventHandler<VlcMediaParsedChangedEventArgs> ParsedChanged;

        private void OnMediaParsedChangedInternal(IntPtr ptr)
        {
#if NET20 || NET35 || NET40 || NET45
            var args = (VlcEventArg)Marshal.PtrToStructure(ptr, typeof(VlcEventArg));
#else
            var args = Marshal.PtrToStructure<VlcEventArg>(ptr);
#endif
            OnMediaParsedChanged(args.eventArgsUnion.MediaParsedChanged.NewStatus);
        }

        public void OnMediaParsedChanged(int newStatus)
        {
            var del = ParsedChanged;
            if (del != null)
                del(this, new VlcMediaParsedChangedEventArgs(newStatus));
        }
    }
}