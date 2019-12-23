using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDevices.Tracks
{
    public class Track
    {
        private int id;
        private string name;
        private string artist;
        private string albumSource;
        private Category style;
        private Time length;

        public Track()
        {
            Id = 0;
            Name = "";
            Artist = "";

        }
        public Track(int Id)
        {
            this.Id = Id;
            Name = "";
            Artist = "";
        }
        public Track(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
            Artist = "";
        }
        public Track(int Id, string Artist, string Name)
        {
            this.Id = Id;
            this.Name = Name;
            this.Artist = Artist;
        }

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Artist { get { return artist; } set { artist = value; } }
        public string AlbumSource { get { return albumSource; } set { albumSource = value; } }
        public string DisplayLength { get { return length.ToString(); } }
        public Time Length { set { length = value; } }
        public Category Style { get { return style; } set { style = value; } }
        public string DisplayName
        {
            get
            {
                if (artist != string.Empty && name != string.Empty)
                {
                    return $"{artist} - {name}";
                }
                else
                {
                    return "unknown";
                }
            }
        }



        public Time GetLength()
        {
            return length;
        }

        //get the lengt of a song in seconds
         public int GetLengthInSeconds()
         {
            int SecondsInLength = length.hours * 3600 + length.minutes * 60 + length.seconds;
            return SecondsInLength;
         }
    }
    
    
    public enum Category
    {
        Ambient, Blues, Country, Disco, Electro, Hardcore, HardRock, HeavyMetal, Hiphop, Jazz, Jumpstyle,
        Klassiek, Latin, Other, Pop, Punk, Reggae, Rock, Soul, Trance, Techno
    }
    public struct Time
    {
        public int hours;
        public int minutes;
        public int seconds;
        public Time(int Hours, int Minutes, int Seconds)
        {
            hours = Hours;
            minutes = Minutes;
            seconds = Seconds;

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
        public Time(int Minutes, int Seconds)
        {
            hours = 0;
            minutes = Minutes;
            seconds = Seconds;

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
        public Time(int Seconds)
        {
            hours = 0;
            minutes = 0;
            seconds = Seconds;

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
        public override string ToString()
        {
            return $"{hours}:{minutes}:{seconds}";
        }
    }
}
