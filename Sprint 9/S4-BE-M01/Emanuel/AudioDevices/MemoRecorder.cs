using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDevices.Devices
{
    public class MemoRecorder : AudioDevices
    {
        //field with the max cartridge type
        private MemoCartridgeType maxCartridgeType = MemoCartridgeType.Unknown;

        //constructor
        public MemoRecorder(int serialIdIN)
        {
            serialId = serialIdIN;
        }

        //returns the capacity as a string
        public override string DisplayStorageCapacity()
        {
            string displayStorageCapacity = "Max capacity ";
            switch (maxCartridgeType)
            {
                case MemoCartridgeType.C60:
                    displayStorageCapacity += "60 min.";
                    break;
                case MemoCartridgeType.C90:
                    displayStorageCapacity += "90 min.";
                    break;
                case MemoCartridgeType.C120:
                    displayStorageCapacity += "120 min.";
                    break;
                default:
                    displayStorageCapacity += "unknown";
                    break;
            }
            return displayStorageCapacity;
        }

        //property
        public MemoCartridgeType MaxCartridgeType { get { return maxCartridgeType; } set { maxCartridgeType = value; } }
    }

    //enum with catridge types
    public enum MemoCartridgeType
    { C60,C90,C120,Unknown }
}
