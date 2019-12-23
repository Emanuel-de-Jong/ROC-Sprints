using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDevices.Tracks
{
    public class TrackList
    {
        //Private fields.
        private List<Track> tracks;

        ///////////////////////
        //Public constructors//
        ///////////////////////

        //Defines 'tracks' as an new list.
        public TrackList()
        {
            tracks = new List<Track>();
        }
        //Sets the list 'tracks' to 'tracksInput'.
        public TrackList(List<Track> tracksInput)
        {
            tracks = tracksInput;
        }

        //////////////////
        //Public methods//
        //////////////////

        //Adds items to 'list<Track> tracks'.
        public void Add(Track t)
        {
            tracks.Add(t);
        }
        //Removes items to 'list<Track> tracks'.
        public void Remove(Track t)
        {
            tracks.Remove(t);
        }
        //Empties everything in 'list<Track> tracks'.
        public void Clear()
        {
            tracks.Clear();
        }
        //Displays all the items in 'list<Track> tracks'.
        public List<Track> GetAllTracks()
        {
            return tracks;
        }
        //Displays a duplicate of 'list<Track> tracks' that had its order randomized.
        public List<Track> Shuffle()
        {
            Random rng = new Random();
            //This line of code makes a duplicate of 'tracks' and orders every item in the list by an randomly generated number. (Source: https://stackoverflow.com/questions/273313/randomize-a-listt)
            List<Track> tracksDupe = tracks.OrderBy(item => rng.Next()).ToList();
            return tracksDupe;
        }

        //////////////
        //Properties//
        //////////////
        
        public int Count { get { return tracks.Count; } }
        public Time TotalTime
        {
            get
            {
                Int32 timeCal = 0;
                //Loops for every 'track' in 'tracks' and gets the lenght if each 'track' in seconds and combines them into one total.
                foreach (Track track in tracks)
                {
                    timeCal =+ track.GetLengthInSeconds();
                }
                //Defines 'totalTime' which is set to 'GetLenght(timecal)'.
                Time totalTime = new Time(timeCal);
                return totalTime;
            }
        }
    }
}
