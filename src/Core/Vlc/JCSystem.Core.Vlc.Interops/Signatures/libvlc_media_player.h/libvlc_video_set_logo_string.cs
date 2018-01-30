using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h
{
    /// <summary>
    /// Set logo option as string.
    /// </summary>
    [LibVlcFunction("libvlc_video_set_logo_string")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetVideoLogoString(IntPtr mediaPlayerInstance, VideoLogoOptions option, Utf8StringHandle value);
}
