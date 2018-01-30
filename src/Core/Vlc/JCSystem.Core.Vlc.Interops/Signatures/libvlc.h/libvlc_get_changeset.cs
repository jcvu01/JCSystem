using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc.h
{
    /// <summary>
    /// Retrieve libvlc changeset.
    /// </summary>
    /// <returns>Return a string containing the libvlc changeset.</returns>
    [LibVlcFunction("libvlc_get_changeset")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate IntPtr GetChangeset();
}
