using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDevices.Devices
{
    public class MemoRecorder : AudioDevices
    {
        //set private fields
        private MemoCartridgetype maxCatridgeType;

        public MemoRecorder(int serialIdIN)
        {
            SerialId = serialIdIN;
        }

        public override string DisplayStorageCapacity()
        {
            string displayStorageCapacity = "Max capacity ";
            switch (maxCatridgeType)
            {
                case MemoCartridgetype.C60:
                    displayStorageCapacity += "60 min.";
                    break;
                case MemoCartridgetype.C90:
                    displayStorageCapacity += "90 min.";
                    break;
                case MemoCartridgetype.C120:
                    displayStorageCapacity += "120 min.";
                    break;
                default:
                    displayStorageCapacity += "unknown";
                    break;
            }
            return displayStorageCapacity;
        }
        public MemoCartridgetype MaxCartridgeType { get { return maxCatridgeType; } set { maxCatridgeType = value; } }
    }
    public enum MemoCartridgetype
    {
        C60, C90, C120, Unknown
    }
    
}
