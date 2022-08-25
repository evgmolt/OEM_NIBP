using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oem_nibp_test.enums
{
    internal enum Errors
    {
        None,
        ZeroPressureCalibration,
        AirNotPump,
        TooHighDecompressionSpeed,
        PulseNotFound,
        PulsationTooSmall,
        TooLowDecompressionSpeed,
        TooManyArtifacts,
        SystolicTooHigh,
        DiastolicTooLow,
        PressureTooHigh,
        TooLongTime,
        WrongCuff
    }
}
