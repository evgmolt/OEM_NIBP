namespace oem_nibp_test
{
    internal static class Constants
    {
        internal const byte CMD_REQUEST = 0xA0;
        internal const byte CMD_START = 0xA1;
        internal const byte CMD_STOP = 0xA2;
        internal const byte CMD_MAN_ON = 0xAC;
        internal const byte CMD_MAN_OFF = 0xAD;

        internal const byte Num_Echo = 0;
        internal const byte Num_SYS = 1;
        internal const byte Num_DIA = 2;
        internal const byte Num_Current = 3;
        internal const byte Num_Status = 4;
        internal const byte Num_Errors = 5;
        internal const byte Num_Settings = 6;
        internal const byte Num_AddIndex = 7;
        internal const byte Num_Additional = 8;
        internal const byte Num_CheckSum = 9;

        internal const byte BytesInResponse = 10;

        //Masks for Status
        internal const byte Mask_Pump  = 0b00000001;
        internal const byte Mask_Valve = 0b00000010;
        internal const byte Mask_Msr   = 0b00000100;
        internal const byte Mask_Pulse = 0b00100000;
        internal const byte Mask_New   = 0b01000000;
        internal const byte Mask_Man8  = 0b10000000;

        //Masks for Settings
        internal const byte Mask_Manometer = 0b00010000;

        internal const byte Add_SerialHigh = 0;
        internal const byte Add_SerialLow  = 1;
        internal const byte Add_Version    = 2;
        internal const byte Add_Mode       = 4;
        internal const byte Add_StartPress = 5;
        internal const byte Add_MAP        = 6;
        internal const byte Add_Pulse      = 7;
    }
}
