using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h
{
    /// <summary>
    /// Get current audio delay.
    /// </summary>
    [LibVlcFunction("libvlc_audio_get_delay")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate long GetAudioDelay(IntPtr mediaPlayerInstance);
}
