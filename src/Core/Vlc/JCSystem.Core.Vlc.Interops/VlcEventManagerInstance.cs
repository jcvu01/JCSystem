using System;
using JCSystem.Core.Vlc.Interops.Signatures;

namespace JCSystem.Core.Vlc.Interops
{
    public abstract class VlcEventManagerInstance : InteropObjectInstance
    {
        private readonly VlcManager myManager;

        internal VlcEventManagerInstance(VlcManager manager, IntPtr pointer) : base(pointer)
        {
            myManager = manager;
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public static implicit operator IntPtr(VlcEventManagerInstance instance)
        {
            return instance.Pointer;
        }
    }
}