﻿using System;
using JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h;

namespace JCSystem.Core.Vlc.Interops
{
    public sealed partial class VlcManager
    {
        public bool IsSeekable(VlcMediaPlayerInstance mediaPlayerInstance)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<IsSeekable>().Invoke(mediaPlayerInstance) == 1;
        }
    }
}
