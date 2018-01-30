using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h
{
    /// <summary>
    /// Get media position.
    /// </summary>
    [LibVlcFunction("libvlc_media_player_get_position")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate float GetMediaPosition(IntPtr mediaPlayerInstance);
}
