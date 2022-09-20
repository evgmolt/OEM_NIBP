namespace oem_nibp_test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labPort = new System.Windows.Forms.Label();
            this.timerRead = new System.Windows.Forms.Timer(this.components);
            this.butRequest = new System.Windows.Forms.Button();
            this.butStart = new System.Windows.Forms.Button();
            this.butStop = new System.Windows.Forms.Button();
            this.butManometerOn = new System.Windows.Forms.Button();
            this.butManometerOff = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labDTError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labPulse = new System.Windows.Forms.Label();
            this.labDia = new System.Windows.Forms.Label();
            this.labSys = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labCurrent = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labMAP = new System.Windows.Forms.Label();
            this.labManometer = new System.Windows.Forms.Label();
            this.timerSendCommand = new System.Windows.Forms.Timer(this.components);
            this.labHeart = new System.Windows.Forms.Label();
            this.labStatus = new System.Windows.Forms.Label();
            this.labError = new System.Windows.Forms.Label();
            this.cbAutoRequest = new System.Windows.Forms.CheckBox();
            this.labelCheck = new System.Windows.Forms.Label();
            this.labSerial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labPort
            // 
            this.labPort.AutoSize = true;
            this.labPort.Location = new System.Drawing.Point(12, 426);
            this.labPort.Name = "labPort";
            this.labPort.Size = new System.Drawing.Size(79, 15);
            this.labPort.TabIndex = 0;
            this.labPort.Text = "Disconnected";
            // 
            // timerRead
            // 
            this.timerRead.Enabled = true;
            this.timerRead.Tick += new System.EventHandler(this.timerRead_Tick);
            // 
            // butRequest
            // 
            this.butRequest.Location = new System.Drawing.Point(24, 47);
            this.butRequest.Name = "butRequest";
            this.butRequest.Size = new System.Drawing.Size(110, 23);
            this.butRequest.TabIndex = 2;
            this.butRequest.Text = "Request";
            this.butRequest.UseVisualStyleBackColor = true;
            this.butRequest.Click += new System.EventHandler(this.butRequest_Click);
            // 
            // butStart
            // 
            this.butStart.Location = new System.Drawing.Point(24, 85);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(110, 23);
            this.butStart.TabIndex = 3;
            this.butStart.Text = "Start";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // butStop
            // 
            this.butStop.Location = new System.Drawing.Point(24, 121);
            this.butStop.Name = "butStop";
            this.butStop.Size = new System.Drawing.Size(110, 23);
            this.butStop.TabIndex = 4;
            this.butStop.Text = "Stop";
            this.butStop.UseVisualStyleBackColor = true;
            this.butStop.Click += new System.EventHandler(this.butStop_Click);
            // 
            // butManometerOn
            // 
            this.butManometerOn.Location = new System.Drawing.Point(24, 159);
            this.butManometerOn.Name = "butManometerOn";
            this.butManometerOn.Size = new System.Drawing.Size(110, 23);
            this.butManometerOn.TabIndex = 5;
            this.butManometerOn.Text = "Manometer ON";
            this.butManometerOn.UseVisualStyleBackColor = true;
            this.butManometerOn.Click += new System.EventHandler(this.butManometerOn_Click);
            // 
            // butManometerOff
            // 
            this.butManometerOff.Location = new System.Drawing.Point(24, 197);
            this.butManometerOff.Name = "butManometerOff";
            this.butManometerOff.Size = new System.Drawing.Size(110, 23);
            this.butManometerOff.TabIndex = 6;
            this.butManometerOff.Text = "Manometer OFF";
            this.butManometerOff.UseVisualStyleBackColor = true;
            this.butManometerOff.Click += new System.EventHandler(this.butManometerOff_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(542, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(226, 319);
            this.listBox1.TabIndex = 7;
            // 
            // labDTError
            // 
            this.labDTError.AutoSize = true;
            this.labDTError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labDTError.ForeColor = System.Drawing.Color.Red;
            this.labDTError.Location = new System.Drawing.Point(397, 33);
            this.labDTError.Name = "labDTError";
            this.labDTError.Size = new System.Drawing.Size(113, 15);
            this.labDTError.TabIndex = 8;
            this.labDTError.Text = "Data transfer error";
            this.labDTError.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(165, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "SYS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(165, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "DIA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(165, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Pulse";
            // 
            // labPulse
            // 
            this.labPulse.AutoSize = true;
            this.labPulse.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labPulse.Location = new System.Drawing.Point(250, 117);
            this.labPulse.Name = "labPulse";
            this.labPulse.Size = new System.Drawing.Size(23, 25);
            this.labPulse.TabIndex = 12;
            this.labPulse.Text = "0";
            // 
            // labDia
            // 
            this.labDia.AutoSize = true;
            this.labDia.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labDia.Location = new System.Drawing.Point(250, 81);
            this.labDia.Name = "labDia";
            this.labDia.Size = new System.Drawing.Size(23, 25);
            this.labDia.TabIndex = 13;
            this.labDia.Text = "0";
            // 
            // labSys
            // 
            this.labSys.AutoSize = true;
            this.labSys.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labSys.Location = new System.Drawing.Point(250, 43);
            this.labSys.Name = "labSys";
            this.labSys.Size = new System.Drawing.Size(23, 25);
            this.labSys.TabIndex = 14;
            this.labSys.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(164, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Current";
            // 
            // labCurrent
            // 
            this.labCurrent.AutoSize = true;
            this.labCurrent.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labCurrent.Location = new System.Drawing.Point(250, 155);
            this.labCurrent.Name = "labCurrent";
            this.labCurrent.Size = new System.Drawing.Size(23, 25);
            this.labCurrent.TabIndex = 16;
            this.labCurrent.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(165, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "MAP";
            // 
            // labMAP
            // 
            this.labMAP.AutoSize = true;
            this.labMAP.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labMAP.Location = new System.Drawing.Point(250, 193);
            this.labMAP.Name = "labMAP";
            this.labMAP.Size = new System.Drawing.Size(23, 25);
            this.labMAP.TabIndex = 18;
            this.labMAP.Text = "0";
            // 
            // labManometer
            // 
            this.labManometer.AutoSize = true;
            this.labManometer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labManometer.Location = new System.Drawing.Point(167, 239);
            this.labManometer.Name = "labManometer";
            this.labManometer.Size = new System.Drawing.Size(147, 25);
            this.labManometer.TabIndex = 19;
            this.labManometer.Text = "Manometer On";
            this.labManometer.Visible = false;
            // 
            // timerSendCommand
            // 
            this.timerSendCommand.Enabled = true;
            this.timerSendCommand.Interval = 500;
            this.timerSendCommand.Tick += new System.EventHandler(this.timerSendCommand_Tick);
            // 
            // labHeart
            // 
            this.labHeart.AutoSize = true;
            this.labHeart.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labHeart.ForeColor = System.Drawing.Color.Red;
            this.labHeart.Location = new System.Drawing.Point(24, 266);
            this.labHeart.Name = "labHeart";
            this.labHeart.Size = new System.Drawing.Size(37, 40);
            this.labHeart.TabIndex = 20;
            this.labHeart.Text = "♥";
            this.labHeart.Visible = false;
            // 
            // labStatus
            // 
            this.labStatus.AutoSize = true;
            this.labStatus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labStatus.Location = new System.Drawing.Point(167, 278);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(66, 25);
            this.labStatus.TabIndex = 21;
            this.labStatus.Text = "Ready";
            // 
            // labError
            // 
            this.labError.AutoSize = true;
            this.labError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labError.ForeColor = System.Drawing.Color.Red;
            this.labError.Location = new System.Drawing.Point(397, 71);
            this.labError.Name = "labError";
            this.labError.Size = new System.Drawing.Size(41, 15);
            this.labError.TabIndex = 22;
            this.labError.Text = "Error: ";
            this.labError.Visible = false;
            // 
            // cbAutoRequest
            // 
            this.cbAutoRequest.AutoSize = true;
            this.cbAutoRequest.Checked = true;
            this.cbAutoRequest.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAutoRequest.Location = new System.Drawing.Point(24, 9);
            this.cbAutoRequest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAutoRequest.Name = "cbAutoRequest";
            this.cbAutoRequest.Size = new System.Drawing.Size(94, 19);
            this.cbAutoRequest.TabIndex = 23;
            this.cbAutoRequest.Text = "Auto request";
            this.cbAutoRequest.UseVisualStyleBackColor = true;
            // 
            // labelCheck
            // 
            this.labelCheck.AutoSize = true;
            this.labelCheck.Location = new System.Drawing.Point(669, 5);
            this.labelCheck.Name = "labelCheck";
            this.labelCheck.Size = new System.Drawing.Size(64, 15);
            this.labelCheck.TabIndex = 25;
            this.labelCheck.Text = "CheckSum";
            // 
            // labSerial
            // 
            this.labSerial.AutoSize = true;
            this.labSerial.Location = new System.Drawing.Point(542, 426);
            this.labSerial.Name = "labSerial";
            this.labSerial.Size = new System.Drawing.Size(80, 15);
            this.labSerial.TabIndex = 26;
            this.labSerial.Text = "Serial number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labSerial);
            this.Controls.Add(this.labelCheck);
            this.Controls.Add(this.cbAutoRequest);
            this.Controls.Add(this.labError);
            this.Controls.Add(this.labStatus);
            this.Controls.Add(this.labHeart);
            this.Controls.Add(this.labManometer);
            this.Controls.Add(this.labMAP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labCurrent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labSys);
            this.Controls.Add(this.labDia);
            this.Controls.Add(this.labPulse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labDTError);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.butManometerOff);
            this.Controls.Add(this.butManometerOn);
            this.Controls.Add(this.butStop);
            this.Controls.Add(this.butStart);
            this.Controls.Add(this.butRequest);
            this.Controls.Add(this.labPort);
            this.Name = "Form1";
            this.Text = "OEM NIBP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labPort;
        private System.Windows.Forms.Timer timerRead;
        private Button butRequest;
        private Button butStart;
        private Button butStop;
        private Button butManometerOn;
        private Button butManometerOff;
        private ListBox listBox1;
        private Label labDTError;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labPulse;
        private Label labDia;
        private Label labSys;
        private Label label4;
        private Label labCurrent;
        private Label label5;
        private Label labMAP;
        private Label labManometer;
        private System.Windows.Forms.Timer timerSendCommand;
        private Label labHeart;
        private Label labStatus;
        private Label labError;
        private CheckBox cbAutoRequest;
        private Label labelCheck;
        private Label labSerial;
    }
}