﻿using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h
{
    /// <summary>
    /// Get length of movie playing
    /// </summary>
    /// <returns>Get the requested movie play rate.</returns>
    [LibVlcFunction("libvlc_media_player_get_length")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate long GetLength(IntPtr mediaPlayerInstance);
}
