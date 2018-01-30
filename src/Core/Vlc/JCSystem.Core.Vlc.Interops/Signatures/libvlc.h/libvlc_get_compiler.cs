using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc.h
{
    /// <summary>
    /// Retrieve libvlc compiler version.
    /// </summary>
    /// <returns>Return a string containing the libvlc compiler version.</returns>
    [LibVlcFunction("libvlc_get_compiler")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate IntPtr GetCompiler();
}
