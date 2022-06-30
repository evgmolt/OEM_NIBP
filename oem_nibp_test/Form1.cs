namespace oem_nibp_test
{
    public partial class Form1 : Form, IMessageHandler
    {
        USBserialPort USBPort;
        bool Connected;
        byte[] DataFromOEM = new byte[Constants.BytesInResponse];
        OEM_NIBP_Status Status;
        byte Error;
        byte NextCommand;

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
                if (bytes != Constants.BytesInResponse)
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
            if (DataFromOEM[(byte)Constants.ByteNum.CheckSum] != GetCheckSum())
            {
//                return;
            }
            labSys.Text = DataFromOEM[(byte)Constants.ByteNum.SYS].ToString();
            labDia.Text = DataFromOEM[(byte)Constants.ByteNum.DIA].ToString();
            int CurrentPressure = 0x100 * Status.Man8 + DataFromOEM[(byte)Constants.ByteNum.Current];
            labCurrent.Text = CurrentPressure.ToString();
            Status = new(DataFromOEM[(byte)Constants.ByteNum.Status]);
            labHeart.Visible = Status.Pulse;
            Error = DataFromOEM[(byte)Constants.ByteNum.Errors];
            if (Error > 0)
            {
                labError.Visible = true;
                labError.Text = "Error: " + Error.ToString();
            }
            else
            {
                labError.Visible = false;
            }
            byte addIndex = DataFromOEM[(byte)Constants.ByteNum.AddIndex];
            if (addIndex == (byte)Constants.AdditionalByteIs.Pulse)
            {
                labPulse.Text = DataFromOEM[(byte)Constants.ByteNum.Additional].ToString();
            }
            if (addIndex == (byte)Constants.AdditionalByteIs.MAP)
            {
                labMAP.Text = DataFromOEM[(byte)Constants.ByteNum.Additional].ToString();
            }
            labManometer.Visible = (DataFromOEM[(byte)Constants.ByteNum.Settings] & Constants.Mask_Manometer) != 0;
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
            NextCommand = (byte)Constants.CMD.REQUEST;
        }

        private void butStart_Click(object sender, EventArgs e)
        {
            NextCommand = (byte)Constants.CMD.START;
        }

        private void butStop_Click(object sender, EventArgs e)
        {
            NextCommand = (byte)Constants.CMD.STOP;
        }

        private void butManometerOn_Click(object sender, EventArgs e)
        {
            NextCommand = (byte)Constants.CMD.MAN_ON;
        }

        private void butManometerOff_Click(object sender, EventArgs e)
        {
            NextCommand = (byte)Constants.CMD.MAN_OFF;
        }

        private void timerSendCommand_Tick(object sender, EventArgs e)
        {
            USBPort.WriteByte(NextCommand);
            if (NextCommand != (byte)Constants.CMD.REQUEST)
            {
                NextCommand = (byte)Constants.CMD.REQUEST;
            }
        }
    }
}