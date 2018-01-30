using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h
{
    /// <summary>
    /// Set the media that will be used by the media_player. If any, previous media will be released.
    /// </summary>
    /// <returns>Return a new media player object, or NULL on error.</returns>
    [LibVlcFunction("libvlc_media_player_set_media")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetMediaToMediaPlayer(IntPtr mediaPlayerInstance, IntPtr mediaInstance);
}
