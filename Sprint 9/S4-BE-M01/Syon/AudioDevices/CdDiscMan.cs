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
        //add Private fields
        private readonly int mBsize = 700;
        private int displayWidth;
        private int displayHeight;
        private bool isEjected = false;

        public int MBsize { get { return mBsize; } }

        public int DisplayWidth { get { return displayWidth; } set { displayWidth = value; } }
        public int DisplayHeight { get { return displayHeight; } set { displayHeight = value; } }
 
        public bool IsEjected { get { return isEjected; } }
        public int TotalPixels { get { return displayHeight * displayWidth; } }

        //add constructors
        public CdDiscMan(int serialIdIN)
        {
            SerialId = serialIdIN;
        }

        //get the resulition in pixels
        public string GetResolutionInfo()
        {
            int totalpixels = DisplayWidth * DisplayHeight;
            return $"Resolution: {totalpixels} pixels";
        }

        //get the sotrage capacity in MB
        public override string DisplayStorageCapacity()
        {
            return MBsize + " mB.";
        }
        //toggle eject status
        public void Eject()
        {
            if (IsEjected == false)
            {
                isEjected = true;
            }
            else
            {
                isEjected = false;
            }
        }

        
    }
}
