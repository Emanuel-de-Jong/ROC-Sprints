using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioDevices.Tracks; //might be wrong

namespace AudioDevices.Interfaces
{
    //has variables with info about a screen
    interface IDisplay
    {
        string GetResolutionInfo();
        int DisplayWidth { get; set; }
        int DisplayHeight { get; set; }
        int TotalPixels { get; }
    }
    //has variables with info about a ist of tracks
    interface ITrackList
    {
        bool HasTracks();
        void AddTrackList(TrackList trackList);
        void RemoveTrackList();

        TrackList TrackList { get; }
    }
}
