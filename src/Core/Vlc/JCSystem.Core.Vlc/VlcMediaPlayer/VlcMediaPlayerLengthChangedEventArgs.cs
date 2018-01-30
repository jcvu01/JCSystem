using System;

namespace JCSystem.Core.Vlc
{
    public sealed class VlcMediaPlayerLengthChangedEventArgs : EventArgs
    {
        public VlcMediaPlayerLengthChangedEventArgs(float newLength)
        {
            NewLength = newLength;
        }

        public float NewLength { get; private set; }
    }
}