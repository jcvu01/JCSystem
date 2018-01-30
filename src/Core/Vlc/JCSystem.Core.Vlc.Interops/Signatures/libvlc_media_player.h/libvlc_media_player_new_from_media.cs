using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h
{
    /// <summary>
    /// Create a Media Player object from a Media.
    /// </summary>
    /// <returns>Return a new media player object, or NULL on error.</returns>
    [LibVlcFunction("libvlc_media_player_new_from_media")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate IntPtr CreateMediaPlayerFromMedia(IntPtr mediaInstance);
}
