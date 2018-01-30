using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h
{
    /// <summary>
    /// Enable or disable deinterlace filter.
    /// </summary>
    [LibVlcFunction("libvlc_video_set_deinterlace")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetVideoDeinterlace(IntPtr mediaPlayerInstance, Utf8StringHandle mode);
}
