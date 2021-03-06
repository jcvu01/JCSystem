﻿using System;
using System.Runtime.InteropServices;
using JCSystem.Core.Vlc.Interops;
using JCSystem.Core.Vlc.Interops.Signatures.libvlc.h;
using JCSystem.Core.Vlc.Interops.Signatures.libvlc_events.h;

namespace JCSystem.Core.Vlc
{
    public partial class VlcMedia
    {
        private EventCallback myOnMediaSubItemTreeAddedInternalEventCallback;
        public event EventHandler<VlcMediaSubItemTreeAddedEventArgs> SubItemTreeAdded;

        private void OnMediaSubItemTreeAddedInternal(IntPtr ptr)
        {
#if NET20 || NET35 || NET40 || NET45
            var args = (VlcEventArg)Marshal.PtrToStructure(ptr, typeof(VlcEventArg));
#else
            var args = Marshal.PtrToStructure<VlcEventArg>(ptr);
#endif
            OnMediaSubItemTreeAdded(new VlcMedia(myVlcMediaPlayer, VlcMediaInstance.New(myVlcMediaPlayer.Manager, args.eventArgsUnion.MediaSubItemTreeAdded.MediaInstance)));
        }

        public void OnMediaSubItemTreeAdded(VlcMedia newSubItemAdded)
        {
            var del = SubItemTreeAdded;
            if (del != null)
                del(this, new VlcMediaSubItemTreeAddedEventArgs(newSubItemAdded));
        }
    }
}