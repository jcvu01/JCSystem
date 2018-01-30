using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h
{
    /// <summary>
    /// Check if media player can pause.
    /// </summary>
    [LibVlcFunction("libvlc_media_player_can_pause")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int IsPausable(IntPtr mediaPlayerInstance);
}
