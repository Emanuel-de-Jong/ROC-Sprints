using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioDevices.Tracks;

namespace AudioDevices.Interfaces
{
    public interface IDisplay
    {
        string GetResolutionInfo();
        int DisplayWidth { get; set; }
        int DisplayHeight { get; set; }
        int TotalPixels { get; }
    }
    public interface ITracklist
    {
        bool HasTracks();
        void AddTrackList(Tracklist trackList);
        void RemoveTrackList();
        Tracklist TrackList { get; }
    }
}
