using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AudioDevices.Tracks;
using AudioDevices.Devices;

namespace SoundSharpMVC.Models
{
    public static class DataProvider
    {
        public static TrackList GenerateDefaultTracks()
        {
            Track t1 = new Track();
            t1.Name = "Yellow";
            t1.Artist = "Coldplay";
            t1.AlbumSource = "Parachutes";
            t1.Length = new Time(0, 4, 29);
            t1.Style = Category.Pop;

            Track t2 = new Track();
            t2.Name = "Shiver";
            t2.Artist = "Coldplay";
            t2.AlbumSource = "Parachutes";
            t2.Length = new Time(0, 4, 59);
            t2.Style = Category.Pop;

            Track t3 = new Track(0, "Maneater", "Nelly Futado");
            t3.AlbumSource = "Loose";
            t3.Length = new Time(281);
            t3.Style = Category.Pop;

            Track t4 = new Track(4, "Prince", "Guitar");
            t4.Length = new Time(3, 72);
            t4.Style = Category.Pop;

            
            var trackList = new TrackList();
            trackList.Add(t1);
            trackList.Add(t2);
            trackList.Add(t3);
            trackList.Add(t4);
            return trackList;
        }

        public static List<MemoRecorder> GetDefaultMemorecorders()
        {
            List<MemoRecorder> recorders = new List<MemoRecorder>();
            MemoRecorder mr1 = new MemoRecorder();
            mr1.Make = "Sony";
            mr1.Model = "IDC-BX700";
            mr1.PriceExBtw = 43.99m;
            mr1.CreationDate = new DateTime(2010, 10, 1);
            MemoRecorder mr2 = new MemoRecorder();
            mr2.Make = "Philips";
            mr2.Model = "Voice Tracer LF";
            mr2.PriceExBtw = 139.00m;
            mr2.CreationDate = new DateTime(2010, 1, 10);
            MemoRecorder mr3 = new MemoRecorder();
            mr3.Make = "Olympus";
            mr3.Model = "VN 500";
            mr3.PriceExBtw = 30.00m;
            mr3.CreationDate = new DateTime(2010, 1, 5);

            recorders.Add(mr1);
            recorders.Add(mr2);
            recorders.Add(mr3);
            return recorders;
        }
        public static List<CdDiscMan> GetDefaultCdDiscMans()
        {
            List<CdDiscMan> discmanlist = new List<CdDiscMan>();
            CdDiscMan discman = new CdDiscMan(1000);
            discman.Make = "JVC";
            discman.Model = "HG-410";
            discman.PriceExBtw = 149.00M;
            discman.DisplayWidth = 320;
            discman.DisplayHeight = 160;
            discman.CreationDate = DateTime.Parse("12-2-2006");

            discmanlist.Add(discman);
            return discmanlist;

        }

        public static List<Mp3Player> GetDefaultMp3Players()
        {
            List<Mp3Player> mp3players = new List<Mp3Player>();
            Mp3Player player = new Mp3Player(1000);
            player.Make = "Creative";
            player.Model = "Alpha";
            player.PriceExBtw = 99.00M;
            player.DisplayWidth = 120;
            player.DisplayHeight = 80;
            player.CreationDate = DateTime.Parse("1-1-2007");
            player.MBSize = 1024;
            Track t1 = new Track(1, "Prince", "Guitar");
            t1.Length = new Time(4, 12);
            Track t2 = new Track(2, "Nelly Furtado", "Say it Right");
            t2.Length = new Time(4, 41);
            Track t3 = new Track(3, "David Guetta & Chris Willis", "Love is gone");
            t3.Length = new Time(3, 50);
            TrackList trackList = new TrackList();
            trackList.Add(t1);
            trackList.Add(t2);
            trackList.Add(t3);
            player.AddTrackList(trackList);

            mp3players.Add(player);
            return mp3players;

        }
    }
}