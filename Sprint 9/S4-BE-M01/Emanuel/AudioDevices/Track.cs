using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDevices.Tracks
{
    /*Class with data about Tracks(Songs) like its duration and name*/
    public class Track
    {
        //fields
        private int id = 0;
        private string name = string.Empty;
        private string artist = string.Empty;
        private string albumSource = string.Empty;
        private Time length = new Time();
        private Category style = Category.Pop;

        //constructors
        public Track(int idIN, string nameIN, string artistIN)
        {
            //assigns the parameters to the corresponding fields
            id = idIN;
            name = nameIN;
            artist = artistIN;
        }
        public Track(int idIN, string nameIN)
        {
            id = idIN;
            name = nameIN;
        }
        public Track(int idIN)
        {
            id = idIN;
        }
        public Track()
        {
        }

        //methodes
        public Time GetLength()
        {
            return length;
        }
        public int GetLengthInSeconds()
        {
            int SecondsInLength = length.hours * 3600 + length.minutes * 60 + length.seconds;
            return SecondsInLength;
        }

        //properties
        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Artist { get { return artist; } set { artist = value; } }
        public string AlbumSource { get { return albumSource; } set { albumSource = value; } }
        public string DisplayLength { get { return length.ToString(); } }
        //only get because there is a method for the set
        public Time Length { set { length = value; } }
        public Category Style { get { return style; } set { style = value; } }
        public string DisplayName
        {
            get
            {
                if (artist != string.Empty || name != string.Empty)
                {
                    return $"{artist} - {name}";
                }
                else
                {
                    return "unknown";
                }
            }
        }
    }


    /*assignment of datatypes*/

    //enum with a list of music genres
    public enum Category
    { Ambient,Blues,Country,Disco,Electro,Hardcore,HardRock,
        HeavyMetal,Hiphop,Jazz,Jumpstyle,Klassiek,Latin,Other,
        Pop,Punk,Reggae,Rock,Soul,Trance,Techno }
    
    //struct with hours, minutes and seconds
    public struct Time
    {
        public int hours;
        public int minutes;
        public int seconds;
        //can have multiple kinds of input
        public Time(int Hours, int Minutes, int Seconds)
        {
            hours = Hours;
            minutes = Minutes;
            seconds = Seconds;
            //adds 1 to minutes when seconds are >= than 60
            while(seconds >= 60)
            {
                seconds -= 60;
                minutes++;
            }
            //same with minutes and hours
            while (minutes >= 60)
            {
                minutes -= 60;
                hours++;
            }
        }
        public Time(int Minutes, int Seconds)
        {
            hours = 0;
            minutes = Minutes;
            seconds = Seconds;
            while (seconds >= 60)
            {
                seconds -= 60;
                minutes++;
            }
            while (minutes >= 60)
            {
                minutes -= 60;
                hours++;
            }
        }
        public Time(int Seconds)
        {
            hours = 0;
            minutes = 0;
            seconds = Seconds;
            while (seconds >= 60)
            {
                seconds -= 60;
                minutes++;
            }
            while (minutes >= 60)
            {
                minutes -= 60;
                hours++;
            }
        }
        //returns hours:minutes:seconds as string
        public override string ToString()
        {
            return $"{hours}:{minutes}:{seconds}";
        }
    }
}
