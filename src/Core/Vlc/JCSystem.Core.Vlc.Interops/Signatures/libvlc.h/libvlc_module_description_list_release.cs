using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc.h
{
    /// <summary>
    /// Release a list of module descriptions.
    /// </summary>
    [LibVlcFunction("libvlc_module_description_list_release")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void ReleaseModuleDescription(IntPtr moduleDescription);
}
