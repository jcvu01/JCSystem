using System;

namespace JCSystem.Core.Vlc
{
    public class VlcMediaSubItemAddedEventArgs : EventArgs
    {
        public VlcMediaSubItemAddedEventArgs(VlcMedia subItemAdded)
        {
            SubItemAdded = subItemAdded;
        }

        public VlcMedia SubItemAdded { get; private set; }
    }
}