using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oem_nibp_test
{
    internal struct OEM_NIBP_Status
    {
        public bool Pump;
        public bool Valve;
        public bool Msr;
        public bool Pulse;
        public bool New;
        public byte Man8;

        public OEM_NIBP_Status(byte status)
        {
            Pump = (status & Constants.Mask_Pump) != 0;
            Valve = (status & Constants.Mask_Valve) != 0;
            Msr = (status & Constants.Mask_Msr) != 0;
            Pulse = (status & Constants.Mask_Pulse) != 0;
            New = (status & Constants.Mask_New) != 0;
            Man8 = (byte)(((status & Constants.Mask_Man8) != 0) ? 1 : 0);
        }
    }
}
