using AudioDevices.Interfaces;
using AudioDevices.Tracks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDevices.Devices
{
    public class Mp3Player : AudioDevice, IDisplay, ITracklist
    {
        private Tracklist trackList = new Tracklist();
        private int mBSize = 0;
        private int displayWidth = 0;
        private int displayHeight = 0;

        public Mp3Player(int serialIdIN)
        {
            serialId = serialIdIN;
        }
        public string GetResolutionInfo()
        {
            return $"Resolution: {TotalPixels} pixels.";
        }
        public bool HasTracks()
        {
            if (trackList.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void AddTrackList(Tracklist trackListIN)
        {
            trackList = trackListIN;
        }

        public void RemoveTrackList()
        {
            trackList.Clear();
        }

        public override string DisplayStorageCapacity()
        {
            if (MbSize > 0)
            {
                return mBSize + " mB";
            }
            else
            {
                return "storage capacity unknown.";
            }

        }

        public int MbSize { get { return mBSize; } set { mBSize = value; } }
        public int TotalPixels { get { return displayHeight * displayWidth; } }
        public int DisplayWidth { get { return displayWidth; } set { displayWidth = value; } }
        public int DisplayHeight { get { return displayHeight; } set { displayHeight = value; } }
        public Tracklist TrackList { get { return trackList; } }

    }
}
