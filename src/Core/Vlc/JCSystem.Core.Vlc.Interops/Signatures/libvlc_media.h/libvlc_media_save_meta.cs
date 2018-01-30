using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media.h
{
    /// <summary>
    /// Save the meta previously set.
    /// </summary>
    [LibVlcFunction("libvlc_media_save_meta")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int SaveMediaMetadatas(IntPtr mediaInstance);
}
