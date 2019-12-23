using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDevices.Tracks
{
    
    public class Track
    {
        //set the private varibles
        private int id;
        private string name;
        private string artist;
        private string albumSource;
        private Category style;
        private Time length;

        public Track()
        {
            Id = 0;
            Artist = "";
            Name = "";
        }
        public Track(int idIN)
        {
            Id = idIN;
            Artist = "";
            Name = "";
        }
        public Track(int idIN, string nameIN)
        {
            Id = idIN;
            Name = nameIN;
            Artist = "";
        }
        public Track(int idIN, string artistIN, string nameIN)
        {
            Id = idIN;
            Name = nameIN;
            Artist = artistIN;
        }

        //set the propertys
        public int Id { get { return id; } set { id = value; } }

        public string Name { get { return name; } set { name = value; } }

        public string Artist { get { return artist; } set { artist = value; } }

        public string DisplayName
        {
            get
            {
                
                if (Name != "" && Artist != "")
                {
                    string displayname = Name + " - " + Artist;
                    return displayname;

                }
                else
                {
                    return "unknown";
                }
                
            }
        }

        public Time Length { set { length = value; } }

        public string DisplayLength { get { return length.ToString();} }

        public string AlbumSource { get { return albumSource; } set { albumSource = value; } }

        public Category Style { get { return style; } set { style = value; } }

        //get the length of a song
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
    //define the categorys
    public enum Category
    {

        Ambient, Blues, Country, Disco, Electro, Hardcore, Hardrock,
        HeavyMetal, Hiphop, Jazz, Jumpstyle, Klassiek, Latin, Other, Pop, Punk, Reggae,
        Rock, Soul, Trance, Techno
    };

    //define the time structore
    public struct Time
    {
        public int hours;
        public int minutes;
        public int seconds;
        public Time(int hoursIN, int minutesIN, int secondsIN)
        {
            minutes = minutesIN;
            hours = hoursIN;
            seconds = secondsIN;

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
        public Time(int minutesIN, int secondsIN)
        {
            hours = 0;
            minutes = minutesIN;
            seconds = secondsIN;

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
        public Time(int secondsIN)
        {
            hours = 0;
            minutes = 0;
            seconds = secondsIN;

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
