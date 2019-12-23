using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioDevices.Tracks;
using AudioDevices.Devices;
using AudioDevices.Interfaces;



namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            Mp3Player player = new Mp3Player(1000); player.Make = "Creative"; player.Model = "Alpha"; player.PriceExBtw = 99.00M; player.DisplayWidth = 120; player.DisplayHeight = 80; player.CreationDate = DateTime.Parse("1-1-2007"); player.MBSize = 1024;

            Track t1 = new Track(1, "Prince", "Guitar"); t1.Length = new Time(4, 12);

            Track t2 = new Track(2, "Nelly Furtado", "Say it Right"); t2.Length = new Time(4, 41);

            Track t3 = new Track(3, "David Guetta & Chris Willis", "Love is gone"); t3.Length = new Time(3, 50);

            TrackList trackList = new TrackList(); trackList.Add(t1); trackList.Add(t2); trackList.Add(t3); player.AddTrackList(trackList);

            Console.WriteLine(player.DisplayIdentity(true, true)); Console.WriteLine("Capacity {0}", player.DisplayStorageCapacity()); Console.WriteLine("Display resolution {0} pixels", player.TotalPixels); Console.WriteLine("Consumer price: {0:f2}", player.ConsumerPrice); Console.WriteLine(player.GetDeviceLifeTime());

            if (player.HasTracks()) { Console.WriteLine("The TrackList of this player has {0} tracks", player.TrackList.Count); foreach (Track t in player.TrackList.GetAllTracks()) Console.WriteLine(t.DisplayName); player.RemoveTrackList(); Console.WriteLine("The TrackList of this player has now {0} tracks", player.TrackList.Count); }
            Console.ReadLine();

        }
    }
}
