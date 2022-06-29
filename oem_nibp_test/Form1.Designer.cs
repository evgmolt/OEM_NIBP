﻿namespace oem_nibp_test
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
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
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
            this.SuspendLayout();
            // 
            // timerStatus
            // 
            this.timerStatus.Enabled = true;
            this.timerStatus.Interval = 500;
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
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
            this.timerRead.Interval = 1000;
            this.timerRead.Tick += new System.EventHandler(this.timerRead_Tick);
            // 
            // butRequest
            // 
            this.butRequest.Location = new System.Drawing.Point(27, 29);
            this.butRequest.Name = "butRequest";
            this.butRequest.Size = new System.Drawing.Size(110, 23);
            this.butRequest.TabIndex = 2;
            this.butRequest.Text = "Request";
            this.butRequest.UseVisualStyleBackColor = true;
            this.butRequest.Click += new System.EventHandler(this.butRequest_Click);
            // 
            // butStart
            // 
            this.butStart.Location = new System.Drawing.Point(27, 67);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(110, 23);
            this.butStart.TabIndex = 3;
            this.butStart.Text = "Start";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // butStop
            // 
            this.butStop.Location = new System.Drawing.Point(27, 103);
            this.butStop.Name = "butStop";
            this.butStop.Size = new System.Drawing.Size(110, 23);
            this.butStop.TabIndex = 4;
            this.butStop.Text = "Stop";
            this.butStop.UseVisualStyleBackColor = true;
            this.butStop.Click += new System.EventHandler(this.butStop_Click);
            // 
            // butManometerOn
            // 
            this.butManometerOn.Location = new System.Drawing.Point(27, 141);
            this.butManometerOn.Name = "butManometerOn";
            this.butManometerOn.Size = new System.Drawing.Size(110, 23);
            this.butManometerOn.TabIndex = 5;
            this.butManometerOn.Text = "Manometer ON";
            this.butManometerOn.UseVisualStyleBackColor = true;
            this.butManometerOn.Click += new System.EventHandler(this.butManometerOn_Click);
            // 
            // butManometerOff
            // 
            this.butManometerOff.Location = new System.Drawing.Point(27, 179);
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
            this.label1.Location = new System.Drawing.Point(169, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "SIS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(169, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "DIA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(169, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Pulse";
            // 
            // labPulse
            // 
            this.labPulse.AutoSize = true;
            this.labPulse.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labPulse.Location = new System.Drawing.Point(254, 99);
            this.labPulse.Name = "labPulse";
            this.labPulse.Size = new System.Drawing.Size(23, 25);
            this.labPulse.TabIndex = 12;
            this.labPulse.Text = "0";
            // 
            // labDia
            // 
            this.labDia.AutoSize = true;
            this.labDia.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labDia.Location = new System.Drawing.Point(254, 63);
            this.labDia.Name = "labDia";
            this.labDia.Size = new System.Drawing.Size(23, 25);
            this.labDia.TabIndex = 13;
            this.labDia.Text = "0";
            // 
            // labSys
            // 
            this.labSys.AutoSize = true;
            this.labSys.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labSys.Location = new System.Drawing.Point(254, 23);
            this.labSys.Name = "labSys";
            this.labSys.Size = new System.Drawing.Size(23, 25);
            this.labSys.TabIndex = 14;
            this.labSys.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(167, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Current";
            // 
            // labCurrent
            // 
            this.labCurrent.AutoSize = true;
            this.labCurrent.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labCurrent.Location = new System.Drawing.Point(254, 137);
            this.labCurrent.Name = "labCurrent";
            this.labCurrent.Size = new System.Drawing.Size(23, 25);
            this.labCurrent.TabIndex = 16;
            this.labCurrent.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(169, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "MAP";
            // 
            // labMAP
            // 
            this.labMAP.AutoSize = true;
            this.labMAP.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labMAP.Location = new System.Drawing.Point(254, 175);
            this.labMAP.Name = "labMAP";
            this.labMAP.Size = new System.Drawing.Size(23, 25);
            this.labMAP.TabIndex = 18;
            this.labMAP.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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

        private System.Windows.Forms.Timer timerStatus;
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
    }
}