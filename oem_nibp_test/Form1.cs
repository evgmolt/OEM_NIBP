namespace oem_nibp_test
{
    public partial class Form1 : Form, IMessageHandler
    {
        USBserialPort USBPort;
        bool Connected;
        byte[] DataFromOEM = new byte[Constants.BytesInResponse];
        OEM_NIBP_Status Status;
        byte Error;

        public event Action<Message> WindowsMessage;
        public Form1()
        {
            InitializeComponent();
            USBPort = new USBserialPort(this, 115200);
            USBPort.ConnectionFailure += onConnectionFailure;
            USBPort.Connect();
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
                USBPort.WriteByte(Constants.OEM_NIBP_REQUEST);
            }
        }

        private void DecomposeData()
        {
            labSys.Text = DataFromOEM[Constants.Num_SYS].ToString();
            labDia.Text = DataFromOEM[Constants.Num_DIA].ToString();
            labCurrent.Text = DataFromOEM[Constants.Num_Current].ToString();
            Status = new(DataFromOEM[Constants.Num_Status]);
            Error = DataFromOEM[Constants.Num_Errors];
            byte addIndex = DataFromOEM[Constants.Num_AddIndex];
            if (addIndex == Constants.Add_Pulse)
            {
                labPulse.Text = DataFromOEM[Constants.Num_Additional].ToString();
            }
            if (addIndex == Constants.Add_MAP)
            {
                labMAP.Text = DataFromOEM[Constants.Num_Additional].ToString();
            }
        }

        private void butRequest_Click(object sender, EventArgs e)
        {
            USBPort.WriteByte(Constants.OEM_NIBP_REQUEST);
        }

        private void butStart_Click(object sender, EventArgs e)
        {
            USBPort.WriteByte(Constants.OEM_NIBP_START);
        }

        private void butStop_Click(object sender, EventArgs e)
        {
            USBPort.WriteByte(Constants.OEM_NIBP_STOP);
        }

        private void butManometerOn_Click(object sender, EventArgs e)
        {
            USBPort.WriteByte(Constants.OEM_NIBP_MAN_ON);
        }

        private void butManometerOff_Click(object sender, EventArgs e)
        {
            USBPort.WriteByte(Constants.OEM_NIBP_MAN_OFF);
        }
    }
}