using System.Windows.Forms.Integration;

namespace Vlc.DotNet.Wpf
{
    public class VlcControl : WindowsFormsHost
    {
        public Forms.VlcControl MediaPlayer { get; }

        public VlcControl()
        {
            MediaPlayer = new Forms.VlcControl();
            Child = MediaPlayer; 
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                Child = null;
                MediaPlayer.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}