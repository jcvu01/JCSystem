using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h
{
    /// <summary>
    /// Set the audio output. Change will be applied after stop and play.
    /// </summary>
    [LibVlcFunction("libvlc_audio_output_set")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetAudioOutput(IntPtr mediaPlayerInstance, Utf8StringHandle audioOutputName);
}
