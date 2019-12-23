using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioDevices.Interfaces;

namespace AudioDevices.Devices 
{
    public class CdDiscMan : AudioDevice , IDisplay
    {
        private readonly int mBSize = 700;
        private int displayWidth=0;
        private int displayHeight=0;
        private bool isEjected = false;

        public CdDiscMan(int serailIdIN)
        {
            serialId = serailIdIN;
        }
        public string GetResolutionInfo()
        {
            return $"Resolution: {TotalPixels} pixels.";
        }

        public override string DisplayStorageCapacity()
        {
            return mBSize + " mB";
        }
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
        public bool IsEjected { get { return isEjected; } }
        public int MBSize { get { return mBSize; } }
        public int TotalPixels { get { return displayHeight * displayWidth; } }
        public int DisplayWidth { get { return displayWidth; } set { displayWidth = value; } }
        public int DisplayHeight { get { return displayHeight; } set { displayHeight = value; } }
    }
}
