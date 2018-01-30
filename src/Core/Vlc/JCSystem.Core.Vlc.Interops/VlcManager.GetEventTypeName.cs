using JCSystem.Core.Vlc.Interops.Signatures.libvlc.h;
using JCSystem.Core.Vlc.Interops.Signatures.libvlc_events.h;

namespace JCSystem.Core.Vlc.Interops
{
    public sealed partial class VlcManager
    {
        public string GetEventTypeName(EventTypes eventType)
        {
            return Utf8InteropStringConverter.Utf8InteropToString(GetInteropDelegate<GetEventTypeName>().Invoke(eventType));
        }
    }
}
