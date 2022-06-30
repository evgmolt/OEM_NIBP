namespace oem_nibp_test
{
    internal static class Constants
    {
        internal enum CMD : byte
        {
            REQUEST = 0xA0,
            START = 0xA1,
            STOP = 0xA2,
            MAN_ON = 0xAC,
            MAN_OFF = 0xAD,
        }

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
        internal const byte BytesInResponse = 10;

        //Masks for Status
        internal enum Mask : byte
        {
            Pump    = 0b00000001,
            Valve   = 0b00000010,
            Msr     = 0b00000100,
            Pulse   = 0b00100000,
            New     = 0b01000000,
            Man8    = 0b10000000,
        }
        //Masks for Settings
        internal const byte Mask_Manometer = 0b00010000;

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
}
