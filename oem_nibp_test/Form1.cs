namespace oem_nibp_test
{
    public partial class Form1 : Form, IMessageHandler
    {
        USBserialPort USBPort;
        bool Connected;

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
            for (int i = 0; i < bytes; i++)
            {
                listView1.Items.Add(USBPort.PortBuf[i].ToString());
            }
            USBPort.BytesRead = 0;
        }

        private void butRequest_Click(object sender, EventArgs e)
        {
            USBPort.WriteByte(77);
        }
    }
}