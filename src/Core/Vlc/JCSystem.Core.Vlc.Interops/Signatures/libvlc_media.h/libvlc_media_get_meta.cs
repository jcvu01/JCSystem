using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media.h
{
    /// <summary>
    /// Read a meta of the media.
    /// </summary>
    [LibVlcFunction("libvlc_media_get_meta")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate IntPtr GetMediaMetadata(IntPtr mediaInstance, MediaMetadatas meta);
}
