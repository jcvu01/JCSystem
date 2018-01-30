using System;
using JCSystem.Core.Vlc.Interops.Signatures.libvlc_media.h;

namespace JCSystem.Core.Vlc
{
    public class VlcMediaMetaChangedEventArgs : EventArgs
    {
        public VlcMediaMetaChangedEventArgs(MediaMetadatas metaType)
        {
            MetaType = metaType;
        }

        public MediaMetadatas MetaType { get; private set; }
    }
}