using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h
{
    /// <summary>
    /// Set media chapter (if applicable).
    /// </summary>
    [LibVlcFunction("libvlc_media_player_set_chapter")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetMediaChapter(IntPtr mediaPlayerInstance, int chapter);
}
