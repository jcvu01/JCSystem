using System;

namespace JCSystem.Core.Vlc.Interops
{
    public sealed class VlcMediaEventManagerInstance : VlcEventManagerInstance
    {
        internal VlcMediaEventManagerInstance(VlcManager manager, IntPtr pointer)
            : base(manager, pointer)
        {
        }
    }
}