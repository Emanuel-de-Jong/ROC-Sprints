using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using AudioDevices.Devices;

namespace SoundSharpMVC.Models
{
    public class VMMemorecorder
    {
        [Key]
        public int SerialId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal PriceExBtw { get; set; }
        public DateTime CreationDate { get; set; }
        public MemoCartridgeType MemoCartridgetype { get; set; }
    }
}