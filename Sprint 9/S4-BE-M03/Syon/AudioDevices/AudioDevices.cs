using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDevices.Devices
{
    public abstract class AudioDevices
    {
        //fields
        protected int serialId = 0;
        protected string model = string.Empty;
        protected string make = string.Empty;
        protected decimal priceExBtw = 0;
        protected DateTime createDate = new DateTime();
        protected readonly static double btwPrecentage = 19.0;

        //modules
        public string DisplayIdentity()
        {
            return "Serial: " + serialId;
        }

        //returns the identity of the device
        public string DisplayIdentity(bool makeInfo, bool modelInfo)
        {
            string str = "Serial: " + serialId;

            if (makeInfo)
            {
                str += " Make: " + make;
            }
            if (modelInfo)
            {
                str += " Model: " + model;
            }

            return str;
        }
        //returns the lifetime of the device in days
        public string GetDeviceLifeTime()
        {
            if (createDate != null)
            {
                return "Lifetime "+ (DateTime.Now - createDate).Days +" days";
            }
            else
            {
                return "Lifetime unknown";
            }
        }

        public abstract string DisplayStorageCapacity();

        //properties
        public int SerialId { get { return serialId; } set { serialId = value; } }
        public string Model { get { return model; } set { model = value; } }
        public string Make { get { return make; } set { make = value; } }
        public DateTime CreationDate { get { return createDate; } set { createDate = value; } }
        public decimal PriceExBtw { get { return priceExBtw; } set { priceExBtw = value; } }
        //returns the price including the btw
        public decimal ConsumerPrice { get { return priceExBtw * (decimal)(1 + btwPrecentage / 100); } }
    }
}
