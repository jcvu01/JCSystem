using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h
{
    /// <summary>
    /// Set a string marquee option value.
    /// </summary>
    [LibVlcFunction("libvlc_video_set_marquee_string")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetVideoMarqueeString(IntPtr mediaPlayerInstance, VideoMarqueeOptions option, Utf8StringHandle value);
}
