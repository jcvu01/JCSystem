﻿using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h
{
    /// <summary>
    /// Toggle pause (no effect if there is no media).
    /// </summary>
    [LibVlcFunction("libvlc_media_player_pause")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void Pause(IntPtr mediaPlayerInstance);
}
