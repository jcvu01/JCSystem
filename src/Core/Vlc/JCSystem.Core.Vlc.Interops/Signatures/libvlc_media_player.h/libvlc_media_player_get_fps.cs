using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h
{
    /// <summary>
    /// Get media fps rate.
    /// </summary>
    [LibVlcFunction("libvlc_media_player_get_fps")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate float GetFramesPerSecond(IntPtr mediaPlayerInstance);
}
