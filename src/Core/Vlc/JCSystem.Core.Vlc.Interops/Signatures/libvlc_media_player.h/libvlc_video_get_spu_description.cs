using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h
{
    /// <summary>
    /// Get the description of available video subtitles.
    /// </summary>
    [LibVlcFunction("libvlc_video_get_spu_description")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate IntPtr GetVideoSpuDescription(IntPtr mediaPlayerInstance);
}
