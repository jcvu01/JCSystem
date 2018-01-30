using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h
{
    /// <summary>
    /// Get a string marquee option value.
    /// </summary>
    [LibVlcFunction("libvlc_video_get_marquee_string")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate IntPtr GetVideoMarqueeString(IntPtr mediaPlayerInstance, VideoMarqueeOptions option);
}
