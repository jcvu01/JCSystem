using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h
{
    /// <summary>
    /// Get current video subtitle.
    /// </summary>
    [LibVlcFunction("libvlc_video_get_spu")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int GetVideoSpu(IntPtr mediaPlayerInstance);
}
