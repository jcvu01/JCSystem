﻿using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media.h
{
    /// <summary>
    /// Create a media for a certain file path.
    /// </summary>
    /// <returns>Return the newly created media or NULL on error.</returns>
    [LibVlcFunction("libvlc_media_new_path")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate IntPtr CreateNewMediaFromPath(IntPtr instance, Utf8StringHandle mrl);
}
