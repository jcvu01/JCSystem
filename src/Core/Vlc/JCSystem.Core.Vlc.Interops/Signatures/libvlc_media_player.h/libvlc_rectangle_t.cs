using System.Runtime.InteropServices;

namespace JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Rectangle
    {
        public int Top;
        public int Left;
        public int Bottom;
        public int Right;
    }
}
