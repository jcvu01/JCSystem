using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h
{
    /// <summary>
    /// Create an empty Media Player object.
    /// </summary>
    /// <returns>Return a new media player object, or NULL on error.</returns>
    [LibVlcFunction("libvlc_media_player_new")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate IntPtr CreateMediaPlayer(IntPtr instance);
}
