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
        public bool Man8;

        public OEM_NIBP_Status(byte status)
        {
            Pump = (status & Constants.Mask_Pump) == 1;
            Valve = (status & Constants.Mask_Valve) == 1;
            Msr = (status & Constants.Mask_Msr) == 1;
            Pulse = (status & Constants.Mask_Pulse) == 1;
            New = (status & Constants.Mask_New) == 1;
            Man8 = (status & Constants.Mask_Man8) == 1;
        }
    }
}
