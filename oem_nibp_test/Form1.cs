﻿using oem_nibp_test.enums;

namespace oem_nibp_test
{
    public partial class Form1 : Form, IMessageHandler
    {
        const byte BytesInResponse = 10;
        byte[] DataFromOEM = new byte[BytesInResponse];
        USBserialPort USBPort;
        OEM_NIBP_Status Status;
        byte NextCommand = (byte)CMD.REQUEST;
        int SerialNum;
        int LowSerialNum;
        int HighSerialNum;
        string Mode = "";

        //Masks for Settings
        const byte Mask_Manometer = 0b00010000;

        public event Action<Message> WindowsMessage;
        public Form1()
        {
            InitializeComponent();
            USBPort = new USBserialPort(this, 115200);
            USBPort.ConnectionFailure += onConnectionFailure;
            USBPort.Connect();
            labHeart.Text = "♥";
        }

        private void onConnectionFailure(Exception obj)
        {
            MessageBoxButtons but = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Error;
            MessageBox.Show("Connection failure", "Error", but, icon);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_DEVICECHANGE = 0x0219;
            if (WindowsMessage != null)
            {
                if (m.Msg == WM_DEVICECHANGE)
                {
                    WindowsMessage(m);
                }
            }
            base.WndProc(ref m);
        }

        private void timerRead_Tick(object sender, EventArgs e)
        {
            if (USBPort?.PortHandle?.IsOpen == true)
            {
                labPort.Text = "Connected to " + USBPort.PortNames[USBPort.CurrentPort];
            }
            else
            {
                labPort.Text = "Disconnected";
                return;
            }
            int bytes = USBPort.BytesRead;
            if (bytes > 0)
            {
                if (bytes != BytesInResponse)
                {
                    labDTError.Visible = true;
                    USBPort.BytesRead = 0;
                    return;
                }

                labDTError.Visible = false;
                listBox1.Items.Clear();

                for (int i = 0; i < bytes; i++)
                {
                    byte value = USBPort.PortBuf[i];
                    listBox1.Items.Add(value.ToString());
                    DataFromOEM[i] = value;
                }

                USBPort.BytesRead = 0;
                DecomposeData();
            }
        }

        private void DecomposeData()
        {
            byte checkSum = GetCheckSum();
            byte checkSum1 = DataFromOEM[(byte)ByteNum.CheckSum];
            if (checkSum1 != checkSum)
            {
                labelCheck.Text = checkSum.ToString() + " " + checkSum1.ToString();
            }
            labelCheck.Text = "";
            labSys.Text = DataFromOEM[(byte)ByteNum.SYS].ToString();
            labDia.Text = DataFromOEM[(byte)ByteNum.DIA].ToString();
            int CurrentPressure = 0x100 * Status.Man8 + DataFromOEM[(byte)ByteNum.Current];
            labCurrent.Text = CurrentPressure.ToString();
            Status = new(DataFromOEM[(byte)ByteNum.Status]);
            if (Status.New)
            {
                labNewData.Visible = true;
            }
            labHeart.Visible = Status.Pulse;
            byte Error = DataFromOEM[(byte)ByteNum.Errors];
            if (Error > 0)
            {
                labError.Visible = true;
                labError.Text = "Error: " + Error.ToString();
            }
            else
            {
                labError.Visible = false;
            }
            byte addIndex = DataFromOEM[(byte)ByteNum.AddIndex];
            switch (addIndex)
            {
                case (byte)AdditionalByteIs.SerialHigh:
                    HighSerialNum = DataFromOEM[(byte)ByteNum.Additional];
                    break;
                case (byte)AdditionalByteIs.SerialLow:
                    LowSerialNum = DataFromOEM[(byte)ByteNum.Additional];
                    SerialNum = 0x100 * HighSerialNum + LowSerialNum;
                    break;
                case (byte)AdditionalByteIs.Version:
                    labSerial.Text = "Serial number " + SerialNum.ToString() + " Version " + DataFromOEM[(byte)ByteNum.Additional];
                    break;
                case (byte)AdditionalByteIs.Mode:
                    switch (DataFromOEM[(byte)ByteNum.Additional] & 0x3)
                    {
                        case (byte)Modes.Manual:
                            Mode = "Manual";
                            break;
                        case (byte)Modes.Automatic:
                            Mode = "Automatic";
                            break;
                        case (byte)Modes.Stat:
                            Mode = "Stat";
                            break;
                        default:
                            break;
                    }
                    break;
                case (byte)AdditionalByteIs.StartPressure:
                    byte value = DataFromOEM[(byte)ByteNum.Additional];
                    if (value == 0)
                    {
                        labStartPressure.Text = "Start pressure : Adaptive";
                    }
                    else
                    {
                        labStartPressure.Text = "Start pressure : " + (80 + 10 * (value - 1)).ToString();
                    }
                    break;
                case (byte)AdditionalByteIs.Pulse:
                    labPulse.Text = DataFromOEM[(byte)ByteNum.Additional].ToString();
                    break;
                case (byte)AdditionalByteIs.AveragePressure:
                    labMAP.Text = DataFromOEM[(byte)ByteNum.Additional].ToString();
                    break;
                default: 
                    break;
            }
            labMode.Text = "Mode : " + Mode;
            labManometer.Visible = (DataFromOEM[(byte)ByteNum.Settings] & Mask_Manometer) != 0;
            labStatus.Text = Status.CurrentStatus switch
            {
                OEM_NIBP_Status.Ready => "Ready",
                OEM_NIBP_Status.Calibration => "Calibration",
                OEM_NIBP_Status.Pumping => "Pumping",
                OEM_NIBP_Status.Measurement => "Measurement",
                _ => "Ready",
            };
        }

        private byte GetCheckSum()
        {
            byte sum = 0;
            for (int i = 0; i < DataFromOEM.Length - 1; i++)
            {
                sum += DataFromOEM[i];
            }
            return sum;
        }

        private void butRequest_Click(object sender, EventArgs e)
        {
            NextCommand = (byte)CMD.REQUEST;
            timerSendCommand.Enabled = true;
        }

        private void butStart_Click(object sender, EventArgs e)
        {
            NextCommand = (byte)CMD.START;
            timerSendCommand.Enabled = true;
            labLastCommand.Text = "Last : " + Enum.GetName(typeof(CMD), 0xA1);
            labNewData.Visible = false;
        }

        private void butStop_Click(object sender, EventArgs e)
        {
            NextCommand = (byte)CMD.STOP;
            timerSendCommand.Enabled = true;
            labLastCommand.Text = "Last : " + Enum.GetName(typeof(CMD), 0xA2);
        }

        private void butManometerOn_Click(object sender, EventArgs e)
        {
            NextCommand = (byte)CMD.MAN_ON;
            timerSendCommand.Enabled = true;
            labLastCommand.Text = "Last : " + Enum.GetName(typeof(CMD), 0xAC);
        }

        private void butManometerOff_Click(object sender, EventArgs e)
        {
            NextCommand = (byte)CMD.MAN_OFF;
            timerSendCommand.Enabled = true;
            labLastCommand.Text = "Last : " + Enum.GetName(typeof(CMD), 0xAD);
        }

        private void timerSendCommand_Tick(object sender, EventArgs e)
        {
            USBPort.WriteByte(NextCommand);
            NextCommand = (byte)CMD.REQUEST;
            timerSendCommand.Enabled = cbAutoRequest.Checked;
        }
    }
}