using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioDevices.Interfaces;

namespace AudioDevices.Devices
{
    public class CdDiscMan : AudioDevices, IDisplay
    {
        //fields
        private int mBSize = 700;
        private int displayWidth = 0;
        private int displayHeight = 0;
        private bool isEjected = false;

        //constructor
        public CdDiscMan()
        {

        }
        public CdDiscMan(int serialIdIN)
        {
            serialId = serialIdIN;
        }

        //returns a string with 'TotalPixels'
        public string GetResolutionInfo()
        {
            return $"Resolution: {TotalPixels} pixels.";
        }

        //togles 'Eject'
        public void Eject()
        {
            if (isEjected)
            {
                isEjected = false;
            }
            else
            {
                isEjected = true;
            }
        }

        //returns a string with the capacity
        public override string DisplayStorageCapacity()
        {
            return mBSize + " mB.";
        }

        //properties
        public int MBSize { get { return mBSize; } set { mBSize = value; } }
        public int DisplayWidth { get { return displayWidth; } set { displayWidth = value; } }
        public int DisplayHeight { get { return displayHeight; } set { displayHeight = value; } }
        //decides the total pixels by multiplying the display height and width
        public int TotalPixels { get { return displayHeight * displayWidth; } }
        public bool IsEjected { get { return isEjected; } }
    }
}
