using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h
{
    /// <summary>
    /// Get an integer marquee option value.
    /// </summary>
    [LibVlcFunction("libvlc_video_get_marquee_int")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int GetVideoMarqueeInteger(IntPtr mediaPlayerInstance, VideoMarqueeOptions option);
}
