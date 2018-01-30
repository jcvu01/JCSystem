using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media.h
{
    /// <summary>
    /// Add an option to the media.
    /// </summary>
    [LibVlcFunction("libvlc_media_add_option")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void AddOptionToMedia(IntPtr mediaInstance, Utf8StringHandle mrl);
}
