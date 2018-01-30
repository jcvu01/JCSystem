using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h
{
    /// <summary>
    /// Is the player able to play.
    /// </summary>
    [LibVlcFunction("libvlc_media_player_will_play")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int CouldPlay(IntPtr mediaPlayerInstance);
}
