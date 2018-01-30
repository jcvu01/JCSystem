using System;

namespace JCSystem.Core.Vlc
{
    public sealed class VlcMediaPlayerTimeChangedEventArgs : EventArgs
    {
        public VlcMediaPlayerTimeChangedEventArgs(long newTime)
        {
            NewTime = newTime;
        }

        public long NewTime { get; private set; }
    }
}