using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h
{
    /// <summary>
    /// Set the requested media play rate.
    /// </summary>
    [LibVlcFunction("libvlc_media_player_set_rate")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetRate(IntPtr mediaPlayerInstance, float rate);
}
