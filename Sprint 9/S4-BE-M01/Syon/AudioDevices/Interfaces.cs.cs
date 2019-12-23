using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioDevices.Tracks;

namespace AudioDevices.Interfaces

{
    interface IDisplay
    {
        string GetResolutionInfo();
        int DisplayWidth { get; set; }
        int DisplayHeight { get; set; }
        int TotalPixels { get; }

        

    }
    interface ITrackList
    {
        bool HasTracks();
        void AddTrackList(TrackList trackList);
        void RemoveTrackList();
        TrackList TrackList { get; }

    }

}
