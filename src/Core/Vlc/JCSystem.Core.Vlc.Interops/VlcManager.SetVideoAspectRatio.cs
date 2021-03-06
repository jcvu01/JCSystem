﻿using System;
using JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h;

namespace JCSystem.Core.Vlc.Interops
{
    public sealed partial class VlcManager
    {
        public void SetVideoAspectRatio(VlcMediaPlayerInstance mediaPlayerInstance, string aspectRatio)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");

            using (var aspectRatioInterop = Utf8InteropStringConverter.ToUtf8StringHandle(aspectRatio))
            {
                GetInteropDelegate<SetVideoAspectRatio>().Invoke(mediaPlayerInstance, aspectRatioInterop);
            }
        }
    }
}
