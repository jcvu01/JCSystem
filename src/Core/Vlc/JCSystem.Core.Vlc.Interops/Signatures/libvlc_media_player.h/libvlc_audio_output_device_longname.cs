using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h
{
    /// <summary>
    ///  Get long name of device, if not available short name given.
    /// </summary>
    [LibVlcFunction("libvlc_audio_output_device_longname")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate IntPtr GetAudioOutputDeviceLongName(IntPtr instance, Utf8StringHandle audioOutputName, int deviceIndex);
}
