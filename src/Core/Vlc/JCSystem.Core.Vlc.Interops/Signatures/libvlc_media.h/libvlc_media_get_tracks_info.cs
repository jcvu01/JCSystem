using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media.h
{
    /// <summary>
    /// Get media descriptor's elementary streams description.
    /// </summary>
    [LibVlcFunction("libvlc_media_get_tracks_info")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int GetMediaTracksInformations(IntPtr mediaInstance, out IntPtr tracksInformationsPointer);
}
