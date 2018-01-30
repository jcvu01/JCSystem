using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h
{
    /// <summary>
    /// Play.
    /// </summary>
    /// <returns>Return 0 if playback started (and was already started), or -1 on error.</returns>
    [LibVlcFunction("libvlc_media_player_play")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int Play(IntPtr mediaPlayerInstance);
}
