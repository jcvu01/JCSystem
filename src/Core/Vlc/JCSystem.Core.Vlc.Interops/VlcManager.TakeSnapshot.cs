using System;
using System.IO;
using JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h;

namespace JCSystem.Core.Vlc.Interops
{
    public sealed partial class VlcManager
    {
        public void TakeSnapshot(VlcMediaPlayerInstance mediaPlayerInstance, FileInfo file, uint width, uint height)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            if(file == null)
                throw new ArgumentNullException("file");
            GetInteropDelegate<TakeSnapshot>().Invoke(mediaPlayerInstance, 0, file.FullName, width, height);
        }
    }
}
