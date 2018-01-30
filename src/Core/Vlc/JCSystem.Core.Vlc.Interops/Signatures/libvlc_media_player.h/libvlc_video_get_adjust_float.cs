using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h
{
    /// <summary>
    /// Get an float adjust option value.
    /// </summary>
    [LibVlcFunction("libvlc_video_get_adjust_float")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate float GetVideoAdjustFloat(IntPtr mediaPlayerInstance, VideoAdjustOptions option);
}
