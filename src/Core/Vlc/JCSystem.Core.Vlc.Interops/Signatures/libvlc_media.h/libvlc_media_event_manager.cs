using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media.h
{
    /// <summary>
    /// Get event manager from media descriptor object.
    /// </summary>
    [LibVlcFunction("libvlc_media_event_manager")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate IntPtr GetMediaEventManager(IntPtr mediaInstance);
}
