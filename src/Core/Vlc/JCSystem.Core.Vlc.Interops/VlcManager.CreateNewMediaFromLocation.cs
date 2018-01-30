using JCSystem.Core.Vlc.Interops.Signatures.libvlc_media.h;

namespace JCSystem.Core.Vlc.Interops
{
    public sealed partial class VlcManager
    {
        public VlcMediaInstance CreateNewMediaFromLocation(string mrl)
        {
            EnsureVlcInstance();

            using (var handle = Utf8InteropStringConverter.ToUtf8StringHandle(mrl))
            {
                return VlcMediaInstance.New(this, GetInteropDelegate<CreateNewMediaFromLocation>().Invoke(myVlcInstance, handle));
            }
        }
    }
}
