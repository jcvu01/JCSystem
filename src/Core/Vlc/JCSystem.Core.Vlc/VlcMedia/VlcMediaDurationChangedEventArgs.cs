using System;

namespace JCSystem.Core.Vlc
{
    public class VlcMediaDurationChangedEventArgs : EventArgs
    {
        public VlcMediaDurationChangedEventArgs(long newDuration)
        {
            NewDuration = newDuration;
        }

        public long NewDuration { get; private set; }
    }
}