namespace WindowsFormsApp33
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
            this.LogTxt = new System.Windows.Forms.TextBox();
            this.MsgTxt = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StopBtn
            // 
            this.StopBtn.Location = new System.Drawing.Point(12, 12);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(72, 53);
            this.StopBtn.TabIndex = 0;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(363, 12);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(72, 53);
            this.StartBtn.TabIndex = 1;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(363, 215);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(72, 66);
            this.SendBtn.TabIndex = 2;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // IpTxt
            // 
            this.IpTxt.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.IpTxt.Location = new System.Drawing.Point(120, 12);
            this.IpTxt.Name = "IpTxt";
            this.IpTxt.Size = new System.Drawing.Size(183, 23);
            this.IpTxt.TabIndex = 3;
            // 
            // PortTxt
            // 
            this.PortTxt.Location = new System.Drawing.Point(120, 42);
            this.PortTxt.Name = "PortTxt";
            this.PortTxt.Size = new System.Drawing.Size(100, 23);
            this.PortTxt.TabIndex = 4;
            // 
            // LogTxt
            // 
            this.LogTxt.AcceptsReturn = true;
            this.LogTxt.Location = new System.Drawing.Point(42, 83);
            this.LogTxt.Multiline = true;
            this.LogTxt.Name = "LogTxt";
            this.LogTxt.ReadOnly = true;
            this.LogTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LogTxt.Size = new System.Drawing.Size(315, 108);
            this.LogTxt.TabIndex = 5;
            this.LogTxt.TextChanged += new System.EventHandler(this.MsgTxt_TextChanged);
            // 
            // MsgTxt
            // 
            this.MsgTxt.Location = new System.Drawing.Point(42, 215);
            this.MsgTxt.Multiline = true;
            this.MsgTxt.Name = "MsgTxt";
            this.MsgTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MsgTxt.Size = new System.Drawing.Size(315, 66);
            this.MsgTxt.TabIndex = 6;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 295);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(439, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 317);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MsgTxt);
            this.Controls.Add(this.LogTxt);
            this.Controls.Add(this.PortTxt);
            this.Controls.Add(this.IpTxt);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.StopBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.TextBox IpTxt;
        private System.Windows.Forms.TextBox PortTxt;
        private System.Windows.Forms.TextBox LogTxt;
        private System.Windows.Forms.TextBox SendTxt;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox MsgTxt;
    }
}

