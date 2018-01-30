using System;
using JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h;

namespace JCSystem.Core.Vlc.Interops
{
    public sealed partial class VlcManager
    {
        public void SetVideoCropGeometry(VlcMediaPlayerInstance mediaPlayerInstance, string cropGeometry)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");

            using (var cropGeometryInterop = Utf8InteropStringConverter.ToUtf8StringHandle(cropGeometry))
            {
                GetInteropDelegate<SetVideoCropGeometry>()
                    .Invoke(mediaPlayerInstance, cropGeometryInterop);
            }
        }
    }
}
