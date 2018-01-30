using JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h;

namespace JCSystem.Core.Vlc.Interops
{
    public sealed partial class VlcMediaPlayerInstance
    {
        public void SetVideoFormatCallbacks(VideoFormatCallback videoFormatCallback, CleanupVideoCallback cleanupCallback)
        {
            myManager.GetInteropDelegate<SetVideoFormatCallbacks>().Invoke(Pointer, videoFormatCallback, cleanupCallback);
        }
    }
}
