using System;

namespace JCSystem.Core.Vlc
{
    public sealed class VlcMediaPlayerPausableChangedEventArgs : EventArgs
    {
        public VlcMediaPlayerPausableChangedEventArgs(bool paused)
        {
            IsPaused = paused;
        }

        public bool IsPaused { get; private set; }
    }
}