using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oem_nibp_test.enums
{
    //Индекс дополнительного байта
    internal enum AdditionalByteIs : byte
    {
        SerialHigh = 0,
        SerialLow = 1,
        Version = 2,
        Mode = 4,
        StartPress = 5,
        MAP = 6,
        Pulse = 7,
    }
}
