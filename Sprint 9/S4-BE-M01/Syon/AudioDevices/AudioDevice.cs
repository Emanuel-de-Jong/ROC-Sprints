using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDevices.Devices
{
    public abstract class AudioDevices
    {
        //Add fields
        private int serialId;
        private string model;
        private string make;
        private decimal priceExBtw;
        private DateTime creationDate;
        protected readonly static double btwPercentage;

        //set Properties
        public int SerialId { get { return serialId; } set { serialId = value; } }
        public string Model { get { return model; } set { model = value; } }
        public string Make { get { return make; } set { make = value; } }
        public decimal PriceExBtw { get { return priceExBtw; } set { priceExBtw = value; } }
        public DateTime CreationDate { get { return creationDate; } set { creationDate = value; } }
        public decimal ConsumerPrice
        {
            get
            {
                //calculate ConsumerPrice
                return priceExBtw * ((Convert.ToDecimal(btwPercentage) / 100) + 1);
            }
        }


        //Methods
        //display the identity
        public string DisplayIdentity()
        {
            return $"Serial: {SerialId}";
        }
        public string DisplayIdentity(Boolean makeinfo, Boolean modelinfo)
        {
            if (makeinfo == true)
            {
                return $" Make: {Make}";
            }
            if (modelinfo == true)
            {
                return $" Model: {Model}";
            }
            else
            {
                return "";
            }
        }
        //display defice life time
        public string GetDeviceLifeTime()
        {
            if (CreationDate != null)
            {
                TimeSpan diff = DateTime.Now.Subtract(CreationDate);
                return $"Lifetime {diff.Days} days";
            }
            else
            {
                return "Lifetime unknown";
            }
        }
        public abstract string DisplayStorageCapacity();

    }
}
