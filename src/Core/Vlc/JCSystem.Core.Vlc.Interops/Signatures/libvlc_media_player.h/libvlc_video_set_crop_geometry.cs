using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h
{
    /// <summary>
    /// Set current crop filter geometry.
    /// </summary>
    [LibVlcFunction("libvlc_video_set_crop_geometry")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetVideoCropGeometry(IntPtr mediaPlayerInstance, Utf8StringHandle cropGeometry);
}
