﻿using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h
{
    /// <summary>
    /// Set new video subtitle.
    /// </summary>
    [LibVlcFunction("libvlc_video_set_spu")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetVideoSpu(IntPtr mediaPlayerInstance, int spu);
}
