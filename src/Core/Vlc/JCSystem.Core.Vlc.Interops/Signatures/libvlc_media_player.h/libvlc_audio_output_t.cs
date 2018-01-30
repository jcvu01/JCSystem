using System;
using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h
{
    [StructLayout(LayoutKind.Sequential)]
    public struct AudioOutputDescriptionStructure
    {
        public string Name;
        public string Description;
        public IntPtr NextAudioOutputDescription;
    }
}
