using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h
{
    /// <summary>
    /// Get current teletext page requested.
    /// </summary>
    [LibVlcFunction("libvlc_video_get_teletext")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int GetVideoTeletext(IntPtr mediaPlayerInstance);
}
