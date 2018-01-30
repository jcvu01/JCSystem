using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows;
using JCSystem.Endpoints.Player.Controls;

namespace JCSystem.Endpoints.Player
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private VlcWpfControl _control;
		readonly DirectoryInfo _vlcLibDirectory;
		public MainWindow()
		{
			InitializeComponent();
			var currentAssembly = Assembly.GetEntryAssembly();
			var currentDirectory = new FileInfo(currentAssembly.Location).DirectoryName;
			
			if (IntPtr.Size == 4)
			{
				_vlcLibDirectory = new DirectoryInfo(Path.Combine(currentDirectory, @"..\..\..\..\..\lib\x86\"));
			}
			else
			{
				_vlcLibDirectory = new DirectoryInfo(Path.Combine(currentDirectory, @"..\..\..\..\..\lib\x64\"));
			}
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			_control?.Dispose();
			_control = new VlcWpfControl();
			_control.MediaPlayer.VlcLibDirectory = _vlcLibDirectory;
			_control.MediaPlayer.EndInit();
			ControlContainer.Content = _control;

			// This can also be called before EndInit
			_control.MediaPlayer.Log += (_, args) =>
			{
				string message = string.Format("libVlc : {0} {1} @ {2}", args.Level, args.Message, args.Module);
				Debug.WriteLine(message);
			};
			_control.MediaPlayer.Play(new Uri("http://download.blender.org/peach/bigbuckbunny_movies/big_buck_bunny_480p_surround-fix.avi"));
		}
	}
}
