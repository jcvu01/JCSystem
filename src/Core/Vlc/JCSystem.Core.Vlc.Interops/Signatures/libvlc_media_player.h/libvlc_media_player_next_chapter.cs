using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h
{
    /// <summary>
    /// Set next media chapter (if applicable).
    /// </summary>
    [LibVlcFunction("libvlc_media_player_next_chapter")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetNextMediaChapter(IntPtr mediaPlayerInstance);
}
