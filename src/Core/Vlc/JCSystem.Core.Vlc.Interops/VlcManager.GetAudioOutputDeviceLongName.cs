using JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h;

namespace JCSystem.Core.Vlc.Interops
{
    public sealed partial class VlcManager
    {
        public string GetAudioOutputDeviceLongName(string audioOutputDescriptionName, int deviceIndex)
        {
            EnsureVlcInstance();

            using (var audioOutputDescriptionNameInterop = Utf8InteropStringConverter.ToUtf8StringHandle(audioOutputDescriptionName))
            {
                return Utf8InteropStringConverter.Utf8InteropToString(GetInteropDelegate<GetAudioOutputDeviceLongName>()
                    .Invoke(myVlcInstance, audioOutputDescriptionNameInterop, deviceIndex));
            }
        }
    }
}
