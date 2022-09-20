using oem_nibp_test.enums;
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

        public int CurrentStatus;

        public const int Ready = 0;
        public const int Calibration = 1;
        public const int Pumping = 2;
        public const int Measurement = 3;
        public OEM_NIBP_Status(byte status)
        {
            Pump = (status & (byte)Mask.Pump) != 0;
            Valve = (status & (byte)Mask.Valve) != 0;
            Msr =   (status & (byte)Mask.Msr) != 0;
            Pulse = (status & (byte)Mask.Pulse) != 0;
            New =   (status & (byte)Mask.New) != 0;
            Man8 =  (byte)(((status & (byte)Mask.Man8) != 0) ? 1 : 0);
            status &= 0b111;
            CurrentStatus = status switch
            {
                0b100 => Calibration,
                0b111 => Pumping,
                0b110 => Measurement,
                _ => Ready,
            };
        }
    }
}
