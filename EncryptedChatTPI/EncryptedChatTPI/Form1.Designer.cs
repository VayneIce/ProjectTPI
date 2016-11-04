namespace EncryptedChatTPI
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.Log = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.PictureBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageConfig = new System.Windows.Forms.TabPage();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblConf1 = new System.Windows.Forms.Label();
            this.pictureConfig = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtFriendName = new System.Windows.Forms.TextBox();
            this.lblConf2 = new System.Windows.Forms.Label();
            this.txtRemoteIP = new System.Windows.Forms.TextBox();
            this.txtMyName = new System.Windows.Forms.TextBox();
            this.txtLocalIP = new System.Windows.Forms.TextBox();
            this.lblMe = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblFriend = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.lblNotConnected = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblConnected = new System.Windows.Forms.Label();
            this.tabPageChat = new System.Windows.Forms.TabPage();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chatBackColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chatTextColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.t = new System.Windows.Forms.Timer(this.components);
            this.CloseBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnSend)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureConfig)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPageChat.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtMessage, "txtMessage");
            this.txtMessage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Tag = "";
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);
            this.txtMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMessage_KeyPress);
            this.txtMessage.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyUp);
            // 
            // Log
            // 
            this.Log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Log.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.Log, "Log");
            this.Log.ForeColor = System.Drawing.Color.Yellow;
            this.Log.Name = "Log";
            this.Log.ReadOnly = true;
            // 
            // btnSend
            // 
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnSend, "btnSend");
            this.btnSend.Name = "btnSend";
            this.btnSend.TabStop = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            this.btnSend.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSend_MouseDown);
            this.btnSend.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSend_MouseUp);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageConfig);
            this.tabControl.Controls.Add(this.tabPageChat);
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPageConfig
            // 
            this.tabPageConfig.BackColor = System.Drawing.Color.Gray;
            this.tabPageConfig.Controls.Add(this.lblDate);
            this.tabPageConfig.Controls.Add(this.lblTime);
            this.tabPageConfig.Controls.Add(this.lblConf1);
            this.tabPageConfig.Controls.Add(this.pictureConfig);
            this.tabPageConfig.Controls.Add(this.tableLayoutPanel1);
            this.tabPageConfig.Controls.Add(this.labelCopyright);
            this.tabPageConfig.Controls.Add(this.lblNotConnected);
            this.tabPageConfig.Controls.Add(this.btnConnect);
            this.tabPageConfig.Controls.Add(this.lblConnected);
            this.tabPageConfig.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.tabPageConfig, "tabPageConfig");
            this.tabPageConfig.Name = "tabPageConfig";
            // 
            // lblDate
            // 
            resources.ApplyResources(this.lblDate, "lblDate");
            this.lblDate.BackColor = System.Drawing.Color.Gray;
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDate.Name = "lblDate";
            // 
            // lblTime
            // 
            resources.ApplyResources(this.lblTime, "lblTime");
            this.lblTime.BackColor = System.Drawing.Color.Gray;
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTime.Name = "lblTime";
            // 
            // lblConf1
            // 
            this.lblConf1.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.lblConf1, "lblConf1");
            this.lblConf1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblConf1.Name = "lblConf1";
            // 
            // pictureConfig
            // 
            this.pictureConfig.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.pictureConfig, "pictureConfig");
            this.pictureConfig.Name = "pictureConfig";
            this.pictureConfig.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtFriendName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblConf2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtRemoteIP, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtMyName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtLocalIP, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblMe, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtPort, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblFriend, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblPort, 0, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Name = "lblName";
            // 
            // txtFriendName
            // 
            this.txtFriendName.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.txtFriendName, "txtFriendName");
            this.txtFriendName.Name = "txtFriendName";
            // 
            // lblConf2
            // 
            resources.ApplyResources(this.lblConf2, "lblConf2");
            this.lblConf2.ForeColor = System.Drawing.Color.White;
            this.lblConf2.Name = "lblConf2";
            // 
            // txtRemoteIP
            // 
            this.txtRemoteIP.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtRemoteIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtRemoteIP, "txtRemoteIP");
            this.txtRemoteIP.Name = "txtRemoteIP";
            // 
            // txtMyName
            // 
            this.txtMyName.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.txtMyName, "txtMyName");
            this.txtMyName.Name = "txtMyName";
            // 
            // txtLocalIP
            // 
            this.txtLocalIP.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.txtLocalIP, "txtLocalIP");
            this.txtLocalIP.Name = "txtLocalIP";
            // 
            // lblMe
            // 
            resources.ApplyResources(this.lblMe, "lblMe");
            this.lblMe.ForeColor = System.Drawing.Color.White;
            this.lblMe.Name = "lblMe";
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.txtPort, "txtPort");
            this.txtPort.Name = "txtPort";
            // 
            // lblFriend
            // 
            resources.ApplyResources(this.lblFriend, "lblFriend");
            this.lblFriend.ForeColor = System.Drawing.Color.White;
            this.lblFriend.Name = "lblFriend";
            // 
            // lblPort
            // 
            resources.ApplyResources(this.lblPort, "lblPort");
            this.lblPort.ForeColor = System.Drawing.Color.White;
            this.lblPort.Name = "lblPort";
            // 
            // labelCopyright
            // 
            resources.ApplyResources(this.labelCopyright, "labelCopyright");
            this.labelCopyright.Name = "labelCopyright";
            // 
            // lblNotConnected
            // 
            this.lblNotConnected.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.lblNotConnected, "lblNotConnected");
            this.lblNotConnected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblNotConnected.Name = "lblNotConnected";
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnConnect, "btnConnect");
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblConnected
            // 
            this.lblConnected.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.lblConnected, "lblConnected");
            this.lblConnected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblConnected.Name = "lblConnected";
            // 
            // tabPageChat
            // 
            this.tabPageChat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPageChat.Controls.Add(this.btnSend);
            this.tabPageChat.Controls.Add(this.txtMessage);
            this.tabPageChat.Controls.Add(this.Log);
            resources.ApplyResources(this.tabPageChat, "tabPageChat");
            this.tabPageChat.Name = "tabPageChat";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip_MouseDown);
            this.menuStrip.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip_MouseMove);
            this.menuStrip.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuStrip_MouseUp);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chatBackColorToolStripMenuItem,
            this.chatTextColorToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            resources.ApplyResources(this.optionsToolStripMenuItem, "optionsToolStripMenuItem");
            // 
            // chatBackColorToolStripMenuItem
            // 
            this.chatBackColorToolStripMenuItem.Name = "chatBackColorToolStripMenuItem";
            resources.ApplyResources(this.chatBackColorToolStripMenuItem, "chatBackColorToolStripMenuItem");
            this.chatBackColorToolStripMenuItem.Click += new System.EventHandler(this.chatBackColorToolStripMenuItem_Click);
            // 
            // chatTextColorToolStripMenuItem
            // 
            this.chatTextColorToolStripMenuItem.Name = "chatTextColorToolStripMenuItem";
            resources.ApplyResources(this.chatTextColorToolStripMenuItem, "chatTextColorToolStripMenuItem");
            this.chatTextColorToolStripMenuItem.Click += new System.EventHandler(this.chatTextColorToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // t
            // 
            this.t.Interval = 1;
            // 
            // CloseBox
            // 
            this.CloseBox.BackColor = System.Drawing.Color.SteelBlue;
            this.CloseBox.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.CloseBox, "CloseBox");
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.TabStop = false;
            this.CloseBox.Click += new System.EventHandler(this.CloseBox_Click);
            this.CloseBox.MouseEnter += new System.EventHandler(this.CloseBox_MouseEnter);
            this.CloseBox.MouseLeave += new System.EventHandler(this.CloseBox_MouseLeave);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.CloseBox);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSend)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPageConfig.ResumeLayout(false);
            this.tabPageConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureConfig)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPageChat.ResumeLayout(false);
            this.tabPageChat.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.RichTextBox Log;
        private System.Windows.Forms.PictureBox btnSend;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageConfig;
        private System.Windows.Forms.TabPage tabPageChat;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chatBackColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chatTextColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblConnected;
        private System.Windows.Forms.Label lblMe;
        private System.Windows.Forms.Label lblFriend;
        private System.Windows.Forms.Label lblNotConnected;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtLocalIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtRemoteIP;
        private System.Windows.Forms.TextBox txtMyName;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.TextBox txtFriendName;
        private System.Windows.Forms.Label lblConf2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblConf1;
        private System.Windows.Forms.PictureBox pictureConfig;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer t;
        private System.Windows.Forms.PictureBox CloseBox;
    }
}

