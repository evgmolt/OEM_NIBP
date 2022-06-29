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
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.labPort = new System.Windows.Forms.Label();
            this.timerRead = new System.Windows.Forms.Timer(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.butRequest = new System.Windows.Forms.Button();
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
            this.labPort.Size = new System.Drawing.Size(38, 15);
            this.labPort.TabIndex = 0;
            this.labPort.Text = "label1";
            // 
            // timerRead
            // 
            this.timerRead.Enabled = true;
            this.timerRead.Interval = 1000;
            this.timerRead.Tick += new System.EventHandler(this.timerRead_Tick);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(408, 29);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(254, 97);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // butRequest
            // 
            this.butRequest.Location = new System.Drawing.Point(41, 29);
            this.butRequest.Name = "butRequest";
            this.butRequest.Size = new System.Drawing.Size(75, 23);
            this.butRequest.TabIndex = 2;
            this.butRequest.Text = "Request";
            this.butRequest.UseVisualStyleBackColor = true;
            this.butRequest.Click += new System.EventHandler(this.butRequest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butRequest);
            this.Controls.Add(this.listView1);
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
        private ListView listView1;
        private Button butRequest;
    }
}