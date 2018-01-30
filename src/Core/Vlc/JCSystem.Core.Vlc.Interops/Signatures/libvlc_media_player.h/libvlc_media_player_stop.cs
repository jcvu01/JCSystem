using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h
{
    /// <summary>
    /// Stop.
    /// </summary>
    [LibVlcFunction("libvlc_media_player_stop")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void Stop(IntPtr mediaPlayerInstance);
}
