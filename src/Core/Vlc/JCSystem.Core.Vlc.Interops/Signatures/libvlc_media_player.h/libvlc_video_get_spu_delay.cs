using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h
{
    /// <summary>
    /// Get the current subtitle delay.
    /// </summary>
    [LibVlcFunction("libvlc_video_get_spu_delay")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate long GetVideoSpuDelay(IntPtr mediaPlayerInstance);
}
