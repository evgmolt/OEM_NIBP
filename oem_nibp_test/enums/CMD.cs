using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oem_nibp_test.enums
{
    //Команды модулю
    internal enum CMD : byte
    {
        REQUEST = 0xA0,
        START = 0xA1,
        STOP = 0xA2,
        MAN_ON = 0xAC,
        MAN_OFF = 0xAD,
    }
}
