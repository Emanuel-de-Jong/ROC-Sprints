using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AudioDevices.Interfaces;
using AudioDevices.Tracks;
using System.Drawing;

namespace AudioDevices.Devices
{
    public class Mp3Player : AudioDevices, IDisplay, ITrackList
    {
        //fields
        private TrackList trackList = new TrackList();
        private int mBSize = 0;
        private int displayWidth = 0;
        private int displayHeight = 0;
        private Image picture;


        //constructor
        public Mp3Player()
        {

        }
        public Mp3Player(int serialIdIN)
        {
            serialId = serialIdIN;
        }
        

        public string GetResolutionInfo()
        {
            return $"Resolution: {TotalPixels} pixels.";
        }

        //returns wether the mp3 player has a tracklist set
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

        //adds to the tracklist
        public void AddTrackList(TrackList trackListIN)
        {
            trackList = trackListIN;
        }
        //clears the tracklist
        public void RemoveTrackList()
        {
            trackList.Clear();
        }
        //displays the capacity
        public override string DisplayStorageCapacity()
        {
            if (mBSize == 0)
            {
                return "Storage capacity unknown.";
            }
            else
            {
                return mBSize + " mB.";
            }
        }

        //properties
        public int MBSize { get { return mBSize; } set { mBSize = value; } }
        public int DisplayWidth { get { return displayWidth; } set { displayWidth = value; } }
        public int DisplayHeight { get { return displayHeight; } set { displayHeight = value; } }
        public int TotalPixels { get { return displayHeight * displayWidth; } }
        public TrackList TrackList { get { return trackList; } }
        public Image Picture { get { return picture; } set { picture = value; } }
    }
}