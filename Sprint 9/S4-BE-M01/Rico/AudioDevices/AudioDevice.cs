using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDevices.Devices
{
    public abstract class AudioDevice
    {
        protected int serialId;
        protected string model;
        protected string make;
        protected decimal priceExBtw;
        protected DateTime createDate;
        protected readonly static double btwPrecentage = 19.0;

        public string DisplayIdentity()
        {
            return "Serail" + serialId;
        }

        public string DisplayIdentity(bool makeInfo, bool modelInfo)
        {
            string str = "Serail" + serialId;
            if (makeInfo)
            {
                str += "make" + makeInfo;
            }
            if (modelInfo)
            {
                str += "model" + modelInfo;
            }
            return str;
        }
        public string GetDeviceLifeTime()
        {
            if (createDate != null)
            {
                return "Lifetime " + (DateTime.Now - createDate).Days + " days";
            }
            else
            {
                return "Lifetime unknown";
            }
        }
        public abstract string DisplayStorageCapacity();

        public int SerialId { get { return serialId; } set { serialId = value; } }
        public string Model { get { return model; } set { model = value; } }
        public string Make { get { return make; } set { make = value; } }
        public DateTime CreationDate { get { return createDate; } set { createDate = value; } }
        public decimal PriceExBtw { get { return priceExBtw; } set { priceExBtw = value; } }

        public decimal ConsumerPrice { get { return priceExBtw * (decimal)(1 + btwPrecentage / 100); } }
    }
}
