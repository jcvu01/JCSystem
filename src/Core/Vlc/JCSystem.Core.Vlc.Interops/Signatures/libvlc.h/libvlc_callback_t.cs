using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc.h
{

    /// <summary>
    /// CCallback function notification.
    /// </summary>
    [LibVlcFunction("libvlc_callback_t")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void EventCallback(IntPtr args);
}
