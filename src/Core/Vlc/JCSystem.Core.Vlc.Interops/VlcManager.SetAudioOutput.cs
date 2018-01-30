using JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h;

namespace JCSystem.Core.Vlc.Interops
{
    public sealed partial class VlcManager
    {
        public void SetAudioOutput(AudioOutputDescriptionStructure output)
        {
            SetAudioOutput(output.Name);
        }

        public void SetAudioOutput(string outputName)
        {
            EnsureVlcInstance();

            using (var outputInterop = Utf8InteropStringConverter.ToUtf8StringHandle(outputName))
            {
                GetInteropDelegate<SetAudioOutput>().Invoke(myVlcInstance, outputInterop);
            }
        }
    }
}
