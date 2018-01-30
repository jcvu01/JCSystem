using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media.h
{
    /// <summary>
    /// Get duration (in ms) of media descriptor object item.
    /// </summary>
    [LibVlcFunction("libvlc_media_get_duration")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate long GetMediaDuration(IntPtr mediaInstance);
}
