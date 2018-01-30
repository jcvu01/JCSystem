using System;
using JCSystem.Core.Vlc.Interops.Signatures;

namespace JCSystem.Core.Vlc.Interops
{
    public sealed class VlcInstance : InteropObjectInstance
    {
        private readonly VlcManager myManager;

        internal VlcInstance(VlcManager manager, IntPtr pointer) : base(pointer)
        {
            myManager = manager;
        }

        protected override void Dispose(bool disposing)
        {
            if (Pointer != IntPtr.Zero)
                myManager.ReleaseInstance(this);
            base.Dispose(disposing);            
        }

        public static implicit operator IntPtr(VlcInstance instance)
        {
            if (instance == null)
                return IntPtr.Zero;

            return instance.Pointer;
        }
    }
}