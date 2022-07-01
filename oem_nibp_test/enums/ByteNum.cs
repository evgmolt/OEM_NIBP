using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oem_nibp_test.enums
{
    //Номер байта в посылке
    internal enum ByteNum : byte
    {
        Echo,
        SYS,
        DIA,
        Current,
        Status,
        Errors,
        Settings,
        AddIndex,
        Additional,
        CheckSum,
    }
}
