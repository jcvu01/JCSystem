﻿using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h
{
    /// <summary>
    /// Get number of available video tracks.
    /// </summary>
    [LibVlcFunction("libvlc_video_get_track_count")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int GetVideoTracksCount(IntPtr mediaPlayerInstance);
}
