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
        public TrackList()
        {
            tracks = new List<Track>();
        }

        public TrackList(List<Track> tracksIN)
        {
            tracks = tracksIN;
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
            var copy = new List<Track>();
            var copy2 = new List<Track>();
            copy = tracks;
            Random r = new Random();
            int randomIndex = 0;
            while (copy.Count > 0)
            {
                randomIndex = r.Next(0, copy.Count); //Choose a random object in the list
                copy2.Add(copy[randomIndex]); //add it to the new, random list
                copy.RemoveAt(randomIndex); //remove to avoid duplicates
            }

            return copy2; //return the new random list
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
