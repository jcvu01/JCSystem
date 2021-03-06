﻿using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc.h
{
    /// <summary>
    /// Clears the LibVLC error status for the current thread. This is optional. By default, the error status is automatically overridden when a new error occurs, and destroyed when the thread exits.
    /// </summary>
    /// <returns>Return the libvlc instance or NULL in case of error.</returns>
    [LibVlcFunction("libvlc_clearerr")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void ClearLastErrorMessage(); 
}
