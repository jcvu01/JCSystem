﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using JCSystem.Core.Vlc.Interops;
using JCSystem.Core.Vlc.Interops.Signatures.libvlc_media_player.h;

namespace JCSystem.Core.Vlc
{
    public sealed class TrackDescription
    {
        public int ID { get; private set; }
        public string Name { get; private set; }

        internal TrackDescription(int id, string name)
        {
            ID = id;
            Name = name;
        }

        internal static List<TrackDescription> GetSubTrackDescription(IntPtr moduleRef)
        {
            var result = new List<TrackDescription>();
            if (moduleRef != IntPtr.Zero)
            {
#if NET20 || NET35 || NET40 || NET45
                var module = (TrackDescriptionStructure)Marshal.PtrToStructure(moduleRef, typeof(TrackDescriptionStructure));
#else
                var module = Marshal.PtrToStructure<TrackDescriptionStructure>(moduleRef);
#endif
                var name = Utf8InteropStringConverter.Utf8InteropToString(module.Name);
                result.Add(new TrackDescription(module.Id, name));
                var data = GetSubTrackDescription(module.NextTrackDescription);
                result.AddRange(data);
            }
            return result;
        }

    }
}
