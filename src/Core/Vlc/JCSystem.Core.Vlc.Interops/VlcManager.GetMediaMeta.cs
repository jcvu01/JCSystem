using System;
using JCSystem.Core.Vlc.Interops.Signatures.libvlc_media.h;

namespace JCSystem.Core.Vlc.Interops
{
    public sealed partial class VlcManager
    {
        public string GetMediaMeta(VlcMediaInstance mediaInstance, MediaMetadatas metadata)
        {
            if (mediaInstance == IntPtr.Zero)
                throw new ArgumentException("Media instance is not initialized.");
            var ptr = GetInteropDelegate<GetMediaMetadata>().Invoke(mediaInstance, metadata);
            return Utf8InteropStringConverter.Utf8InteropToString(ptr);
        }
    }
}
