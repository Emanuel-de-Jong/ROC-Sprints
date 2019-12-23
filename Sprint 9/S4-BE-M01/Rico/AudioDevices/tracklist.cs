using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AudioDevices.Tracks
{
    public class Tracklist
    {
        private List<Track> tracks;

        public Tracklist(List<Track> tracksIN)
        {
            tracks = tracksIN;
        }
        public Tracklist()
        {
            tracks = new List<Track>();
        }

        public void Add(Track t)
        {
            tracks.Add(t);
        }
        public void Remove(Track t)
        {
            tracks.Remove(t);
        }        public void Clear()
        {
            tracks.Clear();
        }        public List<Track> GetAllTracks()
        {
            return tracks;
        }        public List<Track> Shuffle()
        {
            Random rnd = new Random();
            List<Track> tracksCopy = tracks.OrderBy(item => rnd.Next()).ToList();
            return tracksCopy;
        }
        public int Count { get { return tracks.Count; } }
        public Time TotalTime
        {
            get
            {
                int seconds = 0;
                foreach (Track track in tracks)
                {
                    seconds += track.GetLengthInSeconds();
                }
                Time totalTime = new Time(seconds);
                return totalTime;
            }
        }
    }
}
