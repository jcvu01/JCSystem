using System;

namespace JCSystem.Core.Vlc
{
    public sealed class VlcMediaPlayerScrambledChangedEventArgs : EventArgs
    {
        public VlcMediaPlayerScrambledChangedEventArgs(int newScrambled)
        {
            NewScrambled = newScrambled;
        }

        public int NewScrambled { get; private set; }
    }
}