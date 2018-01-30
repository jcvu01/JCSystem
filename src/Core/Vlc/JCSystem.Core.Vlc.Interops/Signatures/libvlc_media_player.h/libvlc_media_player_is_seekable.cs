using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h
{
    /// <summary>
    /// Get media is seekable.
    /// </summary>
    [LibVlcFunction("libvlc_media_player_is_seekable")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int IsSeekable(IntPtr mediaPlayerInstance);
}
