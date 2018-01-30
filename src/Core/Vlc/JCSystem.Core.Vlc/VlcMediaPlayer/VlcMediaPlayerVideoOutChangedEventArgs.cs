using System;

namespace JCSystem.Core.Vlc
{
    public sealed class VlcMediaPlayerVideoOutChangedEventArgs : EventArgs
    {
        public VlcMediaPlayerVideoOutChangedEventArgs(int newCount)
        {
            NewCount = newCount;
        }

        public int NewCount { get; private set; }
    }
}