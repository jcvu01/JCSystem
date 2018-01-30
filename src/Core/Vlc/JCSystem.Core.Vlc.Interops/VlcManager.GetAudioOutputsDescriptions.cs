using JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h;

namespace JCSystem.Core.Vlc.Interops
{
    public sealed partial class VlcManager
    {
        public AudioOutputDescriptionStructure GetAudioOutputsDescriptions()
        {
            EnsureVlcInstance();

            return GetInteropDelegate<GetAudioOutputsDescriptions>().Invoke(myVlcInstance);
        }
    }
}
