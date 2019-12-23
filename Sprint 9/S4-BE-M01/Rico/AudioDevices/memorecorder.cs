using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDevices.Devices
{
    public class MemoRecorder : AudioDevice
    {
        private MemoCartridgeType maxCartridgeType = MemoCartridgeType.Unknown;

        public MemoRecorder(int serialIdIN)
        {
            serialId = serialIdIN;
        }

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

        public MemoCartridgeType MaxCartridgeType { get { return maxCartridgeType; } set { maxCartridgeType = value; } }
    }

    public enum MemoCartridgeType
    { C60, C90, C120, Unknown }
}

