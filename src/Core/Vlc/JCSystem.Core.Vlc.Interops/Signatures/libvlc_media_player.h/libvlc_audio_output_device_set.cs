using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h
{
    /// <summary>
    ///  Set audio output device. Changes are only effective after stop and play.
    /// </summary>
    [LibVlcFunction("libvlc_audio_output_device_set")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetAudioOutputDevice(IntPtr mediaPlayerInstance, Utf8StringHandle audioOutputName, Utf8StringHandle deviceName);
}
