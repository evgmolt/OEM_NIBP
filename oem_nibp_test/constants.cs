using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oem_nibp_test
{
    internal static class constants
    {
        internal const byte OEM_NIBP_REQUEST = 0xA0;
        internal const byte OEM_NIBP_START = 0xA1;
        internal const byte OEM_NIBP_STOP = 0xA2;
        internal const byte OEM_NIBP_MAN_ON = 0xAC;
        internal const byte OEM_NIBP_MAN_OFF = 0xAD;
    }
}
