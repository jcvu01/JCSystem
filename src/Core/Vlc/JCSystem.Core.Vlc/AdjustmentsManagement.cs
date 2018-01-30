using JCSystem.Core.Vlc.Interops;

namespace JCSystem.Core.Vlc
{
    internal class AdjustmentsManagement : IAdjustmentsManagement
    {
        private readonly VlcManager _myManager;
        private readonly VlcMediaPlayerInstance _myMediaPlayer;

        public AdjustmentsManagement(VlcManager manager, VlcMediaPlayerInstance mediaPlayerInstance)
        {
            _myManager = manager;
            _myMediaPlayer = mediaPlayerInstance;
        }

        public bool Enabled
        {
            get => _myManager.GetVideoAdjustEnabled(_myMediaPlayer);
	        set => _myManager.SetVideoAdjustEnabled(_myMediaPlayer, value);
        }

        public float Contrast
        {
            get => _myManager.GetVideoAdjustContrast(_myMediaPlayer);
	        set => _myManager.SetVideoAdjustContrast(_myMediaPlayer, value);
        }

        public float Brightness
        {
            get => _myManager.GetVideoAdjustBrightness(_myMediaPlayer);
	        set => _myManager.SetVideoAdjustBrightness(_myMediaPlayer, value);
        }

        public float Hue
        {
            get => _myManager.GetVideoAdjustHue(_myMediaPlayer);
	        set => _myManager.SetVideoAdjustHue(_myMediaPlayer, value);
        }

        public float Saturation
        {
            get => _myManager.GetVideoAdjustSaturation(_myMediaPlayer);
	        set => _myManager.SetVideoAdjustSaturation(_myMediaPlayer, value);
        }

        public float Gamma
        {
            get => _myManager.GetVideoAdjustGamma(_myMediaPlayer);
	        set => _myManager.SetVideoAdjustGamma(_myMediaPlayer, value);
        }
    }
}
