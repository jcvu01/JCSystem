using System;
using JCSystem.Core.Vlc.Interops.Signatures.libvlc_media.h;

namespace JCSystem.Core.Vlc
{
    public class VlcMediaStateChangedEventArgs : EventArgs
    {
        public VlcMediaStateChangedEventArgs(MediaStates state)
        {
            State = state;
        }

        public MediaStates State { get; private set; }
    }
}