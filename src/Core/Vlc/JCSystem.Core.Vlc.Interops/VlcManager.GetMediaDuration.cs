﻿using System;
using JCSystem.Core.Vlc.Interops.Signatures.libvlc_media.h;

namespace JCSystem.Core.Vlc.Interops
{
    public sealed partial class VlcManager
    {
        public long GetMediaDuration(VlcMediaInstance mediaInstance)
        {
            if (mediaInstance == IntPtr.Zero)
                throw new ArgumentException("Media instance is not initialized.");
            return GetInteropDelegate<GetMediaDuration>().Invoke(mediaInstance);
        }
    }
}
