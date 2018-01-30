using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h
{
    /// <summary>
    ///  Get id name of device.
    /// </summary>
    [LibVlcFunction("libvlc_audio_output_device_id")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate IntPtr GetAudioOutputDeviceName(IntPtr instance, Utf8StringHandle audioOutputName, int deviceIndex);
}
