﻿using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h
{
    /// <summary>
    /// Set adjust option as integer.
    /// </summary>
    [LibVlcFunction("libvlc_video_set_adjust_int")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetVideoAdjustInteger(IntPtr mediaPlayerInstance, VideoAdjustOptions option, int value);
}
