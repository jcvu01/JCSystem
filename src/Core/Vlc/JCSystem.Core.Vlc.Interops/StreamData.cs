using System;
using System.IO;

namespace JCSystem.Core.Vlc.Interops
{
    internal class StreamData
    {
        public IntPtr Handle { get; set; }
        public Stream Stream { get; set; }
        public byte[] Buffer { get; set; }
    }
}
