﻿namespace JCSystem.Core.Vlc
{
    public interface IVideoManagement
    {
        string AspectRatio { get; set; }
        string CropGeometry { get; set; }
        int Teletext { get; set; }
        ITracksManagement Tracks { get; }
        string Deinterlace { set; }
        IMarqueeManagement Marquee { get; }
        ILogoManagement Logo { get; }
        IAdjustmentsManagement Adjustments { get; }
    }
}