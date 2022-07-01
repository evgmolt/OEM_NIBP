using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oem_nibp_test.enums
{
    //Маски для Status
    [Flags]
    internal enum Mask : byte
    {
        Pump    = 0b_0000_0001,
        Valve   = 0b_0000_0010,
        Msr     = 0b_0000_0100,
        Pulse   = 0b_0010_0000,
        New     = 0b_0100_0000,
        Man8    = 0b_1000_0000,
    }
}
