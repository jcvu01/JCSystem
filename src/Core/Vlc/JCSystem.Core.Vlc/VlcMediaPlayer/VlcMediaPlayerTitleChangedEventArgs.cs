using System;

namespace JCSystem.Core.Vlc
{
    public sealed class VlcMediaPlayerTitleChangedEventArgs : EventArgs
    {
        public VlcMediaPlayerTitleChangedEventArgs(int newTitle)
        {
            NewTitle = newTitle;
        }

        public int NewTitle { get; private set; }
    }
}