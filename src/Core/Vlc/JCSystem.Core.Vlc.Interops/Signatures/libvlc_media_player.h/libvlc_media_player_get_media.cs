﻿using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h
{
    /// <summary>
    /// Get the media used by the media_player.
    /// </summary>
    /// <returns>Return the media associated with p_mi, or NULL if no media is associated.</returns>
    [LibVlcFunction("libvlc_media_player_get_media")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate IntPtr GetMediaFromMediaPlayer(IntPtr mediaPlayerInstance);
}
