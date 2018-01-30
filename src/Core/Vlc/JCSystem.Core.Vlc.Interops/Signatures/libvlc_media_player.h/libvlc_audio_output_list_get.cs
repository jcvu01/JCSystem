using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h
{
    /// <summary>
    /// Get the list of available audio outputs.
    /// </summary>
    [LibVlcFunction("libvlc_audio_output_list_get")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate AudioOutputDescriptionStructure GetAudioOutputsDescriptions(IntPtr instance);
}
