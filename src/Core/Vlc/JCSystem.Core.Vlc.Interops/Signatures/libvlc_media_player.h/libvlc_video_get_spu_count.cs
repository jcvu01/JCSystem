using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h
{
    /// <summary>
    /// Get the number of available video subtitles.
    /// </summary>
    [LibVlcFunction("libvlc_video_get_spu_count")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int GetVideoSpuCount(IntPtr mediaPlayerInstance);
}
