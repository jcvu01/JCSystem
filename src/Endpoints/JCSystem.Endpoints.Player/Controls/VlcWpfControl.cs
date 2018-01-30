using System.Windows.Forms.Integration;

namespace JCSystem.Endpoints.Player.Controls
{
	public class VlcWpfControl: WindowsFormsHost
	{
		public VlcControl MediaPlayer { get; }

		public VlcWpfControl()
		{
			MediaPlayer = new VlcControl();
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
