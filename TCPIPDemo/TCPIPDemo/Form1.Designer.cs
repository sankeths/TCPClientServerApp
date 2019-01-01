namespace TCPIPDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDBPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDBServer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDBPwd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDBUid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDBConnect = new System.Windows.Forms.Button();
            this.btnDBDisconnect = new System.Windows.Forms.Button();
            this.txtDBName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClearlog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host:";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(59, 168);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(100, 20);
            this.txtHost.TabIndex = 1;
            this.txtHost.Text = "127.0.0.1";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(311, 167);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(193, 168);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 4;
            this.txtPort.Text = "8910";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(403, 167);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(24, 212);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatus.Size = new System.Drawing.Size(500, 148);
            this.txtStatus.TabIndex = 6;
            this.txtStatus.TextChanged += new System.EventHandler(this.txtStatus_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "DataBase Parameters:";
            // 
            // txtDBPort
            // 
            this.txtDBPort.Location = new System.Drawing.Point(193, 46);
            this.txtDBPort.Name = "txtDBPort";
            this.txtDBPort.Size = new System.Drawing.Size(100, 20);
            this.txtDBPort.TabIndex = 11;
            this.txtDBPort.Text = "3306";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Port:";
            // 
            // txtDBServer
            // 
            this.txtDBServer.Location = new System.Drawing.Point(59, 46);
            this.txtDBServer.Name = "txtDBServer";
            this.txtDBServer.Size = new System.Drawing.Size(100, 20);
            this.txtDBServer.TabIndex = 9;
            this.txtDBServer.Text = "127.0.0.1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Server:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Server Parameters:";
            // 
            // txtDBPwd
            // 
            this.txtDBPwd.Location = new System.Drawing.Point(193, 85);
            this.txtDBPwd.Name = "txtDBPwd";
            this.txtDBPwd.PasswordChar = '*';
            this.txtDBPwd.Size = new System.Drawing.Size(100, 20);
            this.txtDBPwd.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(162, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Pwd:";
            // 
            // txtDBUid
            // 
            this.txtDBUid.Location = new System.Drawing.Point(59, 85);
            this.txtDBUid.Name = "txtDBUid";
            this.txtDBUid.Size = new System.Drawing.Size(100, 20);
            this.txtDBUid.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "UID:";
            // 
            // btnDBConnect
            // 
            this.btnDBConnect.Location = new System.Drawing.Point(311, 85);
            this.btnDBConnect.Name = "btnDBConnect";
            this.btnDBConnect.Size = new System.Drawing.Size(75, 23);
            this.btnDBConnect.TabIndex = 17;
            this.btnDBConnect.Text = "Connect";
            this.btnDBConnect.UseVisualStyleBackColor = true;
            this.btnDBConnect.Click += new System.EventHandler(this.btnDBConnect_Click);
            // 
            // btnDBDisconnect
            // 
            this.btnDBDisconnect.Location = new System.Drawing.Point(403, 85);
            this.btnDBDisconnect.Name = "btnDBDisconnect";
            this.btnDBDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDBDisconnect.TabIndex = 18;
            this.btnDBDisconnect.Text = "Disconnect";
            this.btnDBDisconnect.UseVisualStyleBackColor = true;
            this.btnDBDisconnect.Click += new System.EventHandler(this.btnDBDisconnect_Click);
            // 
            // txtDBName
            // 
            this.txtDBName.Location = new System.Drawing.Point(367, 46);
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(100, 20);
            this.txtDBName.TabIndex = 20;
            this.txtDBName.Text = "cartapplication";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(305, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Database:";
            // 
            // btnClearlog
            // 
            this.btnClearlog.Location = new System.Drawing.Point(449, 369);
            this.btnClearlog.Name = "btnClearlog";
            this.btnClearlog.Size = new System.Drawing.Size(75, 23);
            this.btnClearlog.TabIndex = 21;
            this.btnClearlog.Text = "clearlog";
            this.btnClearlog.UseVisualStyleBackColor = true;
            this.btnClearlog.Click += new System.EventHandler(this.btnClearlog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 404);
            this.Controls.Add(this.btnClearlog);
            this.Controls.Add(this.txtDBName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnDBDisconnect);
            this.Controls.Add(this.btnDBConnect);
            this.Controls.Add(this.txtDBPwd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDBUid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDBPort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDBServer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShoppingCart Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDBPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDBServer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDBPwd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDBUid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDBConnect;
        private System.Windows.Forms.Button btnDBDisconnect;
        private System.Windows.Forms.TextBox txtDBName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClearlog;
    }
}

