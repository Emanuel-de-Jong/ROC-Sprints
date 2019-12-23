using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDevices.Tracks
{
    public class TrackList
    {
        //field with Track class variables
        private List<Track> tracks;


        //constructors
        public TrackList(List<Track> tracksIN)
        {
            tracks = tracksIN;
        }
        public TrackList()
        {
            tracks = new List<Track>();
        }

        //methodes
        public void Add(Track t)
        {
            tracks.Add(t);
        }
        public void Remove(Track t)
        {
            tracks.Remove(t);
        }
        //clears the list
        public void Clear()
        {
            tracks.Clear();
        }
        public List<Track> GetAllTracks()
        {
            return tracks;
        }
        public List<Track> Shuffle()
        {
            Random rnd = new Random();
            //makes a copy of 'tracks' and shuffles it
            List<Track> tracksCopy = tracks.OrderBy(item => rnd.Next()).ToList();
            return tracksCopy;
        }

        //properties
        public int Count { get { return tracks.Count; } }
        public Time TotalTime
        {
            get
            {
                int seconds = 0;
                //counts up every length of every track in seconds
                foreach (Track track in tracks)
                {
                    seconds += track.GetLengthInSeconds();
                }
                //makes a Time struct out of it
                Time totalTime = new Time(seconds);
                return totalTime;
            }
        }
    }
}
