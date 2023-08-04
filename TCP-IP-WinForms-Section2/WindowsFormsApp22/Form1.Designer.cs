namespace WindowsFormsApp22
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
            this.StopBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.SendBtn = new System.Windows.Forms.Button();
            this.IpTxt = new System.Windows.Forms.TextBox();
            this.PortTxt = new System.Windows.Forms.TextBox();
            this.MsgTxt = new System.Windows.Forms.TextBox();
            this.statusLb1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LogTxt = new System.Windows.Forms.TextBox();
            this.statusLb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StopBtn
            // 
            this.StopBtn.Location = new System.Drawing.Point(274, 12);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(74, 52);
            this.StopBtn.TabIndex = 0;
            this.StopBtn.Text = "Disconnect";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(377, 12);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(64, 52);
            this.StartBtn.TabIndex = 1;
            this.StartBtn.Text = "Connect";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(365, 240);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(76, 52);
            this.SendBtn.TabIndex = 2;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // IpTxt
            // 
            this.IpTxt.Location = new System.Drawing.Point(79, 12);
            this.IpTxt.Name = "IpTxt";
            this.IpTxt.Size = new System.Drawing.Size(189, 23);
            this.IpTxt.TabIndex = 3;
            // 
            // PortTxt
            // 
            this.PortTxt.Location = new System.Drawing.Point(79, 41);
            this.PortTxt.Name = "PortTxt";
            this.PortTxt.Size = new System.Drawing.Size(100, 23);
            this.PortTxt.TabIndex = 4;
            // 
            // MsgTxt
            // 
            this.MsgTxt.Location = new System.Drawing.Point(79, 240);
            this.MsgTxt.Multiline = true;
            this.MsgTxt.Name = "MsgTxt";
            this.MsgTxt.Size = new System.Drawing.Size(269, 52);
            this.MsgTxt.TabIndex = 5;
            // 
            // statusLb1
            // 
            this.statusLb1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusLb1.Location = new System.Drawing.Point(0, 295);
            this.statusLb1.Name = "statusLb1";
            this.statusLb1.Size = new System.Drawing.Size(449, 22);
            this.statusLb1.TabIndex = 6;
            this.statusLb1.Text = "Disconnected";
            this.statusLb1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusLb1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // LogTxt
            // 
            this.LogTxt.AcceptsReturn = true;
            this.LogTxt.Location = new System.Drawing.Point(79, 84);
            this.LogTxt.MaxLength = 1000000;
            this.LogTxt.Multiline = true;
            this.LogTxt.Name = "LogTxt";
            this.LogTxt.Size = new System.Drawing.Size(269, 130);
            this.LogTxt.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 317);
            this.Controls.Add(this.LogTxt);
            this.Controls.Add(this.statusLb1);
            this.Controls.Add(this.MsgTxt);
            this.Controls.Add(this.PortTxt);
            this.Controls.Add(this.IpTxt);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.StopBtn);
            this.Name = "Form1";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusLb1.ResumeLayout(false);
            this.statusLb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.TextBox IpTxt;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox MsgTxt;
        private System.Windows.Forms.TextBox PortTxt;
        private System.Windows.Forms.StatusStrip statusLb1;
        private System.Windows.Forms.TextBox LogTxt;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

