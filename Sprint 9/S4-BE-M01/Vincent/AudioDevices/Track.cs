using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDevices.Tracks
{
    public class Track
    {
        private int id = 0;                 //Id of the track.
        private string name = "";           //Name of the track.
        private string artist = "";         //Name of the tracks artist.
        private string albumSource = "";    //Name of the albums source.
        private Category style;             //Music style category.
        private Time length;                //Lenght of the track.

        //This defines the tracks id, name, and arist. (Constructor)
        public Track()
        {
        }
        public Track(int idInput)
        {
            id = idInput;
        }
        public Track(int idInput, string nameInput)
        {
            id = idInput;
            name = nameInput;
        }
        public Track(int idInput, string nameInput, string artistInput)
        {
            id = idInput;
            name = nameInput;
            artist = artistInput;
        }

        //A methode to get the length of a track.
        public Time GetLength()
        {
            return length;
        }
        //A methode to get the length of a track in seconds.
        public int GetLengthInSeconds()
        {
            int returnValue = Convert.ToInt32(length.seconds) + Convert.ToInt32(length.minutes * 60) + Convert.ToInt32(length.hours * 60 * 60);
            return returnValue;
        }
        //Properties.
        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Artist { get { return artist; } set { artist = value; } }
        public Time Length { set { length = value; } }
        public string DisplayLength { get { return length.ToString(); } }
        public Category Style { get { return style; } set { style = value; } }
        public string AlbumSource { get { return albumSource; } set { albumSource = value; } }
        public string DisplayName { get { if (artist == "" || name == "") { return "unknown"; } else { return artist + name; } } }
    }

    //The enumerator to define/save the tracks style. (Enumerator)
    public enum Category
    {
        Ambient, Blues, Country, Disco, Electro, Hardcore,
        HardRock, HeavyMetal, Hiphop, Jazz, Jumpstyle,
        Klassiek, Latin, Other, Pop, Punk,
        Reggae, Rock, Soul, Trance, Techno
    };

    //The structure so define/save the tracks lenght. (Structure)
    public struct Time
    {
        public int hours;
        public int minutes;
        public int seconds;

        public Time(int secIn)
        {
            hours = 0;
            minutes = 0;
            seconds = secIn;

            while (seconds > 60)
            {
                minutes += 1;
                seconds -= 60;
            }

            while (minutes > 60)
            {
                hours += 1;
                minutes -= 60;
            }
        }

        public Time(int minIn, int secIn)
        {
            hours = 0;
            minutes = minIn;
            seconds = secIn;

            while (seconds > 60)
            {
                minutes += 1;
                seconds -= 60;
            }

            while (minutes > 60)
            {
                hours += 1;
                minutes -= 60;
            }
        }

        public Time(int houIn, int minIn, int secIn)
        {
            minutes = minIn;
            hours = houIn;
            seconds = secIn;

            while (seconds > 60)
            {
                minutes += 1;
                seconds -= 60;
            }

            while (minutes > 60)
            {
                hours += 1;
                minutes -= 60;
            }
        }
        //An override to get a string output with the time.
        public override string ToString()
        {
            return $"{hours}:{minutes}:{seconds}";
        }
    };
}
