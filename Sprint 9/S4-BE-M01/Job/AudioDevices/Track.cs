using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDevices.Tracks
{
    public class Track
    {
        int trackId;                //Unique numeric ID for the track.
        string trackName;           //Name of the track.
        string trackArtist;         //Name of the artist.
        string trackAlbumSource;    //Name of the album the track originates from.
        Category* trackGenre;       //Music genre of the track.
        Time** trackLength;         //Length of the track.

        //The enumerator with all of the music genres.
        enum Category
        {
            Ambient, Blues, Country, Disco, Electro, Hardcore, HardRock, Hardstyle, HeavyMetal,
            HipHop, Jazz, Klassiek, Latin, Other, Pop, Punk, Reggae, Rock, Soul, Trance, Techno
        }

        //The Time structure.
        public struct Time
        {

            public int trackSeconds;    //
            public int trackMinutes;    //
            public int trackHours;      //

            public Time(int seconds)
            {
                trackHours = seconds;
            }

            public Time(int minutes, int seconds)
            {
                trackMinutes = minutes;
                trackSeconds = seconds;
            }

            public Time(int hours, int minutes, int seconds)
            {
                trackHours = hours;
                trackMinutes = minutes;
                trackSeconds = seconds;
            }

        }

        public override string ToString()
        {
            return $"{hours}:{minutes}:{seconds}";
        }

        public void GetLength()
        {

        }

        public void GetLengthInSeconds()
        {

        }
        
    }
}
