﻿using System;
using System.Runtime.InteropServices;
using JCSystem.Core.Vlc.Interops.Signatures.libvlc.h;
using JCSystem.Core.Vlc.Interops.Signatures.libvlc_events.h;
using JCSystem.Core.Vlc.Interops.Signatures.libvlc_media.h;

namespace JCSystem.Core.Vlc
{
    public partial class VlcMedia
    {
        private EventCallback myOnMediaMetaChangedInternalEventCallback;
        public event EventHandler<VlcMediaMetaChangedEventArgs> MetaChanged;

        private void OnMediaMetaChangedInternal(IntPtr ptr)
        {
#if NET20 || NET35 || NET40 || NET45
            var args = (VlcEventArg)Marshal.PtrToStructure(ptr, typeof(VlcEventArg));
#else
            var args = Marshal.PtrToStructure<VlcEventArg>(ptr);
#endif
            OnMediaMetaChanged(args.eventArgsUnion.MediaMetaChanged.MetaType);
        }

        public void OnMediaMetaChanged(MediaMetadatas metaType)
        {
            var del = MetaChanged;
            if (del != null)
                del(this, new VlcMediaMetaChangedEventArgs(metaType));
        }
    }
}