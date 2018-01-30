using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h
{
    /// <summary>
    /// Set the subtitle delay.
    /// </summary>
    [LibVlcFunction("libvlc_video_set_spu_delay")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetVideoSpuDelay(IntPtr mediaPlayerInstance, long delay);
}
