using JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h;

namespace JCSystem.Core.Vlc.Interops
{
    public sealed partial class VlcManager
    {
        public VlcMediaPlayerInstance CreateMediaPlayer()
        {
            EnsureVlcInstance();

            return new VlcMediaPlayerInstance(this, GetInteropDelegate<CreateMediaPlayer>().Invoke(myVlcInstance));
        }
    }
}
