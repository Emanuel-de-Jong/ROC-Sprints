using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using AudioDevices.Devices;
using AudioDevices.Tracks;
using System.Drawing;

namespace SoundSharpMVC.Models
{
    public class VMMp3Player
    {
        [Key]
        public int SerialId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal PriceExBtw { get; set; }
        public DateTime CreationDate { get; set; }
        public TrackList trackList { get; set; }
        public int MbSize { get; set; }
        public int DisplayWidth { get; set; }
        public int DisplayHeight { get; set; }
    }
}