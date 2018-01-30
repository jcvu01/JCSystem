using System;

namespace JCSystem.Core.Vlc.Interops
{
    public sealed class VlcMediaPlayerEventManagerInstance : VlcEventManagerInstance
    {
        internal VlcMediaPlayerEventManagerInstance(VlcManager manager, IntPtr pointer)
            : base(manager, pointer)
        {
        }
    }
}