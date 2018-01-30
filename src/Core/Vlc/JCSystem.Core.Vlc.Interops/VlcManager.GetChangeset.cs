using JCSystem.Core.Vlc.Interops.Signatures.libvlc.h;

namespace JCSystem.Core.Vlc.Interops
{
    public sealed partial class VlcManager
    {
        public string GetChangeset()
        {
            return Utf8InteropStringConverter.Utf8InteropToString(GetInteropDelegate<GetChangeset>().Invoke());
        }
    }
}
