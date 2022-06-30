using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oem_nibp_test.enums
{
    //Masks for Status
    internal enum Mask : byte
    {
        Pump = 0b00000001,
        Valve = 0b00000010,
        Msr = 0b00000100,
        Pulse = 0b00100000,
        New = 0b01000000,
        Man8 = 0b10000000,
    }
}
