using oem_nibp_test.enums;

namespace oem_nibp_test
{
    public partial class Form1 : Form, IMessageHandler
    {
        const byte BytesInResponse = 10;
        byte[] DataFromOEM = new byte[BytesInResponse];
        USBserialPort USBPort;
        bool Connected;
        OEM_NIBP_Status Status;
        byte Error;
        byte NextCommand;

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

        private void timerStatus_Tick(object sender, EventArgs e)
        {
            if (USBPort == null)
            {
                labPort.Text = "Disconnected";
                Connected = false;
                return;
            }
            if (USBPort.PortHandle == null)
            {
                labPort.Text = "Disconnected";
                Connected = false;
                return;
            }
            if (USBPort.PortHandle.IsOpen)
            {
                labPort.Text = "Connected to " + USBPort.PortNames[USBPort.CurrentPort];
                Connected = true;
            }
            else
            {
                labPort.Text = "Disconnected";
                Connected = false;
            }
        }

        private void timerRead_Tick(object sender, EventArgs e)
        {
            if (USBPort == null) return;
            if (USBPort.PortHandle == null) return;
            if (!USBPort.PortHandle.IsOpen) return;
            int bytes = USBPort.BytesRead;
            if (bytes > 0)
            {
                listBox1.Items.Clear();
                if (bytes != BytesInResponse)
                {
                    labDTError.Visible = true;
                    return;
                }

                labDTError.Visible = false;
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
            if (DataFromOEM[(byte)ByteNum.CheckSum] != GetCheckSum())
            {
//                return;
            }
            labSys.Text = DataFromOEM[(byte)ByteNum.SYS].ToString();
            labDia.Text = DataFromOEM[(byte)ByteNum.DIA].ToString();
            int CurrentPressure = 0x100 * Status.Man8 + DataFromOEM[(byte)ByteNum.Current];
            labCurrent.Text = CurrentPressure.ToString();
            Status = new(DataFromOEM[(byte)ByteNum.Status]);
            labHeart.Visible = Status.Pulse;
            Error = DataFromOEM[(byte)ByteNum.Errors];
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
            if (addIndex == (byte)AdditionalByteIs.Pulse)
            {
                labPulse.Text = DataFromOEM[(byte)ByteNum.Additional].ToString();
            }
            if (addIndex == (byte)AdditionalByteIs.MAP)
            {
                labMAP.Text = DataFromOEM[(byte)ByteNum.Additional].ToString();
            }
            labManometer.Visible = (DataFromOEM[(byte)ByteNum.Settings] & Mask_Manometer) != 0;
            labMeasurement.Text = Status.MeasurementStatus switch
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
            for (int i = 0; i < DataFromOEM.Length; i++)
            {
                sum += DataFromOEM[i];
            }
            return sum;
        }

        private void butRequest_Click(object sender, EventArgs e)
        {
            NextCommand = (byte)CMD.REQUEST;
        }

        private void butStart_Click(object sender, EventArgs e)
        {
            NextCommand = (byte)CMD.START;
        }

        private void butStop_Click(object sender, EventArgs e)
        {
            NextCommand = (byte)CMD.STOP;
        }

        private void butManometerOn_Click(object sender, EventArgs e)
        {
            NextCommand = (byte)CMD.MAN_ON;
        }

        private void butManometerOff_Click(object sender, EventArgs e)
        {
            NextCommand = (byte)CMD.MAN_OFF;
        }

        private void timerSendCommand_Tick(object sender, EventArgs e)
        {
            USBPort.WriteByte(NextCommand);
            if (NextCommand != (byte)CMD.REQUEST)
            {
                NextCommand = (byte)CMD.REQUEST;
            }
        }
    }
}