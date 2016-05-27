namespace Tup.WebSocketTest
{
    partial class FormMainWebSocket4Net
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonConnent = new System.Windows.Forms.Button();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.labelServer = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.buttonRepeatConnect = new System.Windows.Forms.Button();
            this.textBoxRepeatCount = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxMsg = new System.Windows.Forms.TextBox();
            this.panelSend = new System.Windows.Forms.Panel();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.labelConnectStatus = new System.Windows.Forms.Label();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.labelRegisterName = new System.Windows.Forms.Label();
            this.progressBarConnect = new System.Windows.Forms.ProgressBar();
            this.textBoxWSUrlFormat = new System.Windows.Forms.TextBox();
            this.panelConnect = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCookie = new System.Windows.Forms.TextBox();
            this.textBoxQDHeader = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DefaultToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelSend.SuspendLayout();
            this.panelConnect.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConnent
            // 
            this.buttonConnent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConnent.Location = new System.Drawing.Point(63, 2);
            this.buttonConnent.Name = "buttonConnent";
            this.buttonConnent.Size = new System.Drawing.Size(162, 62);
            this.buttonConnent.TabIndex = 0;
            this.buttonConnent.Text = "Connect";
            this.buttonConnent.UseVisualStyleBackColor = true;
            this.buttonConnent.Click += new System.EventHandler(this.buttonConnent_Click);
            // 
            // textBoxServer
            // 
            this.textBoxServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxServer.Location = new System.Drawing.Point(103, 159);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(295, 21);
            this.textBoxServer.TabIndex = 8;
            this.textBoxServer.Text = "192.168.1.176";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPort.Location = new System.Drawing.Point(421, 159);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(77, 21);
            this.textBoxPort.TabIndex = 0;
            this.textBoxPort.Text = "88";
            // 
            // labelServer
            // 
            this.labelServer.AutoSize = true;
            this.labelServer.Location = new System.Drawing.Point(50, 159);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(47, 12);
            this.labelServer.TabIndex = 7;
            this.labelServer.Text = "Server:";
            // 
            // labelPort
            // 
            this.labelPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(404, 159);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(11, 12);
            this.labelPort.TabIndex = 9;
            this.labelPort.Text = ":";
            // 
            // buttonRepeatConnect
            // 
            this.buttonRepeatConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRepeatConnect.Location = new System.Drawing.Point(63, 99);
            this.buttonRepeatConnect.Name = "buttonRepeatConnect";
            this.buttonRepeatConnect.Size = new System.Drawing.Size(162, 62);
            this.buttonRepeatConnect.TabIndex = 3;
            this.buttonRepeatConnect.Text = "Batch Connect";
            this.buttonRepeatConnect.UseVisualStyleBackColor = true;
            this.buttonRepeatConnect.Click += new System.EventHandler(this.buttonRepeatConnect_Click);
            // 
            // textBoxRepeatCount
            // 
            this.textBoxRepeatCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRepeatCount.Location = new System.Drawing.Point(10, 99);
            this.textBoxRepeatCount.Name = "textBoxRepeatCount";
            this.textBoxRepeatCount.Size = new System.Drawing.Size(47, 21);
            this.textBoxRepeatCount.TabIndex = 3;
            this.textBoxRepeatCount.Text = "5000";
            // 
            // buttonSend
            // 
            this.buttonSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSend.Location = new System.Drawing.Point(660, 0);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(72, 72);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxMsg
            // 
            this.textBoxMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMsg.Location = new System.Drawing.Point(0, 0);
            this.textBoxMsg.Multiline = true;
            this.textBoxMsg.Name = "textBoxMsg";
            this.textBoxMsg.Size = new System.Drawing.Size(647, 72);
            this.textBoxMsg.TabIndex = 0;
            this.textBoxMsg.Text = "chat.send://{msg:\"hello\"}";
            // 
            // panelSend
            // 
            this.panelSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSend.Controls.Add(this.textBoxMsg);
            this.panelSend.Controls.Add(this.buttonSend);
            this.panelSend.Enabled = false;
            this.panelSend.Location = new System.Drawing.Point(10, 254);
            this.panelSend.Name = "panelSend";
            this.panelSend.Size = new System.Drawing.Size(732, 75);
            this.panelSend.TabIndex = 9;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutput.Location = new System.Drawing.Point(10, 334);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(731, 150);
            this.textBoxOutput.TabIndex = 3;
            // 
            // labelConnectStatus
            // 
            this.labelConnectStatus.AutoSize = true;
            this.labelConnectStatus.BackColor = System.Drawing.Color.IndianRed;
            this.labelConnectStatus.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelConnectStatus.Location = new System.Drawing.Point(-1, 0);
            this.labelConnectStatus.Name = "labelConnectStatus";
            this.labelConnectStatus.Size = new System.Drawing.Size(63, 14);
            this.labelConnectStatus.TabIndex = 0;
            this.labelConnectStatus.Text = "OffLine";
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Enabled = false;
            this.buttonDisconnect.Location = new System.Drawing.Point(68, 0);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(88, 23);
            this.buttonDisconnect.TabIndex = 1;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // labelRegisterName
            // 
            this.labelRegisterName.AutoSize = true;
            this.labelRegisterName.Location = new System.Drawing.Point(181, 9);
            this.labelRegisterName.Name = "labelRegisterName";
            this.labelRegisterName.Size = new System.Drawing.Size(0, 12);
            this.labelRegisterName.TabIndex = 0;
            // 
            // progressBarConnect
            // 
            this.progressBarConnect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarConnect.Location = new System.Drawing.Point(302, 4);
            this.progressBarConnect.Name = "progressBarConnect";
            this.progressBarConnect.Size = new System.Drawing.Size(427, 24);
            this.progressBarConnect.TabIndex = 0;
            // 
            // textBoxWSUrlFormat
            // 
            this.textBoxWSUrlFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWSUrlFormat.Location = new System.Drawing.Point(103, 8);
            this.textBoxWSUrlFormat.Name = "textBoxWSUrlFormat";
            this.textBoxWSUrlFormat.Size = new System.Drawing.Size(395, 21);
            this.textBoxWSUrlFormat.TabIndex = 1;
            this.textBoxWSUrlFormat.Text = "ws://{0}:{1}/wstest";
            // 
            // panelConnect
            // 
            this.panelConnect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelConnect.Controls.Add(this.label3);
            this.panelConnect.Controls.Add(this.label2);
            this.panelConnect.Controls.Add(this.textBoxServer);
            this.panelConnect.Controls.Add(this.labelPort);
            this.panelConnect.Controls.Add(this.label1);
            this.panelConnect.Controls.Add(this.textBoxPort);
            this.panelConnect.Controls.Add(this.labelServer);
            this.panelConnect.Controls.Add(this.textBoxCookie);
            this.panelConnect.Controls.Add(this.textBoxQDHeader);
            this.panelConnect.Controls.Add(this.textBoxWSUrlFormat);
            this.panelConnect.Location = new System.Drawing.Point(12, 49);
            this.panelConnect.Name = "panelConnect";
            this.panelConnect.Size = new System.Drawing.Size(501, 199);
            this.panelConnect.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cookies:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Custom Headers:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "UrlFormat:";
            // 
            // textBoxCookie
            // 
            this.textBoxCookie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCookie.Location = new System.Drawing.Point(103, 96);
            this.textBoxCookie.Multiline = true;
            this.textBoxCookie.Name = "textBoxCookie";
            this.textBoxCookie.Size = new System.Drawing.Size(395, 54);
            this.textBoxCookie.TabIndex = 6;
            this.DefaultToolTip.SetToolTip(this.textBoxCookie, "key1:value1\r\nkey2:value2");
            // 
            // textBoxQDHeader
            // 
            this.textBoxQDHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQDHeader.Location = new System.Drawing.Point(103, 35);
            this.textBoxQDHeader.Multiline = true;
            this.textBoxQDHeader.Name = "textBoxQDHeader";
            this.textBoxQDHeader.Size = new System.Drawing.Size(395, 54);
            this.textBoxQDHeader.TabIndex = 4;
            this.DefaultToolTip.SetToolTip(this.textBoxQDHeader, "key1:value1\r\nkey2:value2");
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(25, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 1);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.labelConnectStatus);
            this.panel2.Controls.Add(this.buttonDisconnect);
            this.panel2.Controls.Add(this.progressBarConnect);
            this.panel2.Location = new System.Drawing.Point(13, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(731, 31);
            this.panel2.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.buttonConnent);
            this.panel4.Controls.Add(this.textBoxRepeatCount);
            this.panel4.Controls.Add(this.buttonRepeatConnect);
            this.panel4.Location = new System.Drawing.Point(519, 49);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(225, 199);
            this.panel4.TabIndex = 2;
            // 
            // FormMainWebSocket4Net
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 496);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelConnect);
            this.Controls.Add(this.labelRegisterName);
            this.Controls.Add(this.panelSend);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "FormMainWebSocket4Net";
            this.Text = "Chat Test WebSocket";
            this.panelSend.ResumeLayout(false);
            this.panelSend.PerformLayout();
            this.panelConnect.ResumeLayout(false);
            this.panelConnect.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnent;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label labelServer;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxMsg;
        private System.Windows.Forms.Panel panelSend;
        private System.Windows.Forms.Label labelConnectStatus;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Label labelRegisterName;
        private System.Windows.Forms.Button buttonRepeatConnect;
        private System.Windows.Forms.TextBox textBoxRepeatCount;
        private System.Windows.Forms.ProgressBar progressBarConnect;
        private System.Windows.Forms.TextBox textBoxWSUrlFormat;
        private System.Windows.Forms.Panel panelConnect;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxCookie;
        private System.Windows.Forms.TextBox textBoxQDHeader;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolTip DefaultToolTip;
        private System.Windows.Forms.Panel panel4;
    }
}

