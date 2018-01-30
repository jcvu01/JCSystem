﻿using System.Collections;
using System.Collections.Generic;
using JCSystem.Core.Vlc.Interops;

namespace JCSystem.Core.Vlc
{
    public sealed class AudioOutputDevices : IEnumerable<AudioOutputDevice>
    {
        private VlcManager myManager;
        private VlcMediaPlayerInstance myMediaPlayerInstance;
        private AudioOutputDescription myAudioOutputDescription;

        public int Count
        {
            get
            {
                return myManager.GetAudioOutputDeviceCount(myAudioOutputDescription.Name);
            }
        }

        internal AudioOutputDevices(AudioOutputDescription audioOutputDescription, VlcManager manager, VlcMediaPlayerInstance mediaPlayerInstance)
        {
            myAudioOutputDescription = audioOutputDescription;
            myManager = manager;
            myMediaPlayerInstance = mediaPlayerInstance;
        }

        public IEnumerator<AudioOutputDevice> GetEnumerator()
        {
            for (int id = 0; id < Count; id++)
            {
                yield return new AudioOutputDevice(myManager, myMediaPlayerInstance, myAudioOutputDescription, id);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
