using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//gemaakt door erel
namespace AudioDevices.Tracks
{
    public class Track
    {
        //maak de int
        private int id;
        private string name;
        private string artist;
        private string albumSource;
        private Category style;
        private Time length;
        public Track(int id, string name, string artist)
        {

        }
        public Track(int id, string name)
        {

        }
        public Track(int id)
        {

        }
        public Track()
        {

        }
        public Time GetLength(int hours, int minutes, int seconds)
        {
            length = new Time(hours, minutes, seconds);
            return length;
        }
        public int GetLengthInseconds()
        {
            return length.seconds;
        }
        public int id
        {
            get { return id; }
            set { id = value; }
        }
    }

    enum Category
    {
        Ambient, Blues, Country, Disco, Electro, Hardcore, HardRock,
        HeavyMetal, Hiphop, Jazz, Jumpstyle, Klassiek, Latin, Other,
        Pop, Punk, Reggae, Rock, Soul, Trance, Techno
    }

    public struct Time
    {
        public Time(int hours, int minutes, int seconds)
        {

            while (seconds >= 60)
            {
                seconds -= 60;
                minutes++;
            }
            while (minutes >= 60)
            {
                minutes -= 60;
                Hours++;
            }
        }
        public Time(int minutes, int seconds)
        {
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
        public Time(int seconds)
        {
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
        public override string ToString()
        {
            return $"{hours}:{minutes}:{seconds}";
        }
    }
}
