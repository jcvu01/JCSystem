using System;
using JCSystem.Core.Vlc.Interops.Signatures.libvlc_media.h;

namespace JCSystem.Core.Vlc.Interops
{
    public sealed partial class VlcManager
    {
        public void AddOptionFlagToMedia(VlcMediaInstance mediaInstance, string option, uint flag)
        {
            if (mediaInstance == IntPtr.Zero)
                throw new ArgumentException("Media instance is not initialized.");

            using (var handle = Utf8InteropStringConverter.ToUtf8StringHandle(option))
            {
                GetInteropDelegate<AddOptionFlagToMedia>().Invoke(mediaInstance, handle, flag);
            }
        }
    }
}
