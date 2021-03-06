﻿using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h
{
    /// <summary>
    /// Set audio track.
    /// </summary>
    [LibVlcFunction("libvlc_audio_set_track")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetAudioTrack(IntPtr mediaPlayerInstance, int trackId);
}
