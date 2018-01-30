using JCSystem.Core.Vlc.Interops.Signatures.libvlc.h;

namespace JCSystem.Core.Vlc.Interops
{
    public sealed partial class VlcManager
    {
        public void ClearLastErrorMessage()
        {
            GetInteropDelegate<ClearLastErrorMessage>().Invoke();
        }
    }
}
