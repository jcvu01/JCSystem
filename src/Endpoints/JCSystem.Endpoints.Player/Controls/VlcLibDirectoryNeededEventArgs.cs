using System;
using System.IO;

namespace JCSystem.Endpoints.Player.Controls
{
    public sealed class VlcLibDirectoryNeededEventArgs : EventArgs
    {
        public DirectoryInfo VlcLibDirectory { get; set; }
    }
}