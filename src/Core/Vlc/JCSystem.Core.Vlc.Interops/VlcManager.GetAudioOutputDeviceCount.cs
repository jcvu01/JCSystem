using JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h;

namespace JCSystem.Core.Vlc.Interops
{
    public sealed partial class VlcManager
    {
        public int GetAudioOutputDeviceCount(string outputName)
        {
            EnsureVlcInstance();

            return GetInteropDelegate<GetAudioOutputDeviceCount>().Invoke(myVlcInstance, outputName);
        }
    }
}
