using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media.h
{
    /// <summary>
    /// Get the current statistics about the media descriptor object.
    /// </summary>
    [LibVlcFunction("libvlc_media_get_stats")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int GetMediaStats(IntPtr mediaInstance, out MediaStatsStructure stats);
}
