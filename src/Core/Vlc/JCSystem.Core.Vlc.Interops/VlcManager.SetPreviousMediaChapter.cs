﻿using System;
using JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h;

namespace JCSystem.Core.Vlc.Interops
{
    public sealed partial class VlcManager
    {
        public void SetPreviousMediaChapter(VlcMediaPlayerInstance mediaPlayerInstance)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetPreviousMediaChapter>().Invoke(mediaPlayerInstance);
        }
    }
}
