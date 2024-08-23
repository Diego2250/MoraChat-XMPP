namespace Proyecto1_Redes.Forms
{
    partial class MoraChat
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
            this.tcChat = new MaterialSkin.Controls.MaterialTabControl();
            this.tabDM = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.swGroupChatSM = new MaterialSkin.Controls.MaterialSwitch();
            this.tbMessageSM = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btSendMessage = new MaterialSkin.Controls.MaterialButton();
            this.tbUserSM = new MaterialSkin.Controls.MaterialTextBox2();
            this.tabChats = new System.Windows.Forms.TabPage();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.btSendFile = new MaterialSkin.Controls.MaterialButton();
            this.btSendChatMsg = new MaterialSkin.Controls.MaterialButton();
            this.tbChatMsg = new MaterialSkin.Controls.MaterialTextBox();
            this.flpChat = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabOthers = new System.Windows.Forms.TabPage();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.cmbRooms = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.btsuscribeRoom = new MaterialSkin.Controls.MaterialButton();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btAddUser = new MaterialSkin.Controls.MaterialButton();
            this.tbAddUser = new MaterialSkin.Controls.MaterialTextBox2();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.btSetPresenceMsg = new MaterialSkin.Controls.MaterialButton();
            this.tbPresenceMsg = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbPresence = new MaterialSkin.Controls.MaterialComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btDeleteAcct = new MaterialSkin.Controls.MaterialButton();
            this.btLogOut = new MaterialSkin.Controls.MaterialButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbJid = new MaterialSkin.Controls.MaterialLabel();
            this.tcChat.SuspendLayout();
            this.tabDM.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.tabChats.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.tabOthers.SuspendLayout();
            this.materialCard5.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.tabProfile.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcChat
            // 
            this.tcChat.Controls.Add(this.tabDM);
            this.tcChat.Controls.Add(this.tabChats);
            this.tcChat.Controls.Add(this.tabOthers);
            this.tcChat.Controls.Add(this.tabProfile);
            this.tcChat.Depth = 0;
            this.tcChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcChat.Location = new System.Drawing.Point(3, 64);
            this.tcChat.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcChat.Multiline = true;
            this.tcChat.Name = "tcChat";
            this.tcChat.SelectedIndex = 0;
            this.tcChat.Size = new System.Drawing.Size(841, 498);
            this.tcChat.TabIndex = 0;
            this.tcChat.SelectedIndexChanged += new System.EventHandler(this.tcChat_SelectedIndexChanged);
            this.tcChat.Selected += new System.Windows.Forms.TabControlEventHandler(this.tcChat_Selected);
            this.tcChat.TabIndexChanged += new System.EventHandler(this.tcChat_TabIndexChanged);
            // 
            // tabDM
            // 
            this.tabDM.Controls.Add(this.materialCard1);
            this.tabDM.Location = new System.Drawing.Point(4, 22);
            this.tabDM.Name = "tabDM";
            this.tabDM.Padding = new System.Windows.Forms.Padding(3);
            this.tabDM.Size = new System.Drawing.Size(833, 472);
            this.tabDM.TabIndex = 0;
            this.tabDM.Text = "Direct Message";
            this.tabDM.UseVisualStyleBackColor = true;
            this.tabDM.Click += new System.EventHandler(this.tabDM_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.swGroupChatSM);
            this.materialCard1.Controls.Add(this.tbMessageSM);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.btSendMessage);
            this.materialCard1.Controls.Add(this.tbUserSM);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(220, 21);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(393, 430);
            this.materialCard1.TabIndex = 0;
            // 
            // swGroupChatSM
            // 
            this.swGroupChatSM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.swGroupChatSM.AutoSize = true;
            this.swGroupChatSM.Depth = 0;
            this.swGroupChatSM.Location = new System.Drawing.Point(90, 295);
            this.swGroupChatSM.Margin = new System.Windows.Forms.Padding(0);
            this.swGroupChatSM.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swGroupChatSM.MouseState = MaterialSkin.MouseState.HOVER;
            this.swGroupChatSM.Name = "swGroupChatSM";
            this.swGroupChatSM.Ripple = true;
            this.swGroupChatSM.Size = new System.Drawing.Size(213, 37);
            this.swGroupChatSM.TabIndex = 11;
            this.swGroupChatSM.Text = "Send to a group chat?";
            this.swGroupChatSM.UseVisualStyleBackColor = true;
            this.swGroupChatSM.CheckedChanged += new System.EventHandler(this.materialSwitch1_CheckedChanged);
            // 
            // tbMessageSM
            // 
            this.tbMessageSM.AnimateReadOnly = false;
            this.tbMessageSM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbMessageSM.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbMessageSM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMessageSM.Depth = 0;
            this.tbMessageSM.HideSelection = true;
            this.tbMessageSM.Hint = "Message";
            this.tbMessageSM.Location = new System.Drawing.Point(71, 161);
            this.tbMessageSM.MaxLength = 32767;
            this.tbMessageSM.MouseState = MaterialSkin.MouseState.OUT;
            this.tbMessageSM.Name = "tbMessageSM";
            this.tbMessageSM.PasswordChar = '\0';
            this.tbMessageSM.ReadOnly = false;
            this.tbMessageSM.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbMessageSM.SelectedText = "";
            this.tbMessageSM.SelectionLength = 0;
            this.tbMessageSM.SelectionStart = 0;
            this.tbMessageSM.ShortcutsEnabled = true;
            this.tbMessageSM.Size = new System.Drawing.Size(250, 100);
            this.tbMessageSM.TabIndex = 10;
            this.tbMessageSM.TabStop = false;
            this.tbMessageSM.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbMessageSM.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(87, 27);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(229, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Send a message to specific user";
            // 
            // btSendMessage
            // 
            this.btSendMessage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btSendMessage.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btSendMessage.Depth = 0;
            this.btSendMessage.HighEmphasis = true;
            this.btSendMessage.Icon = null;
            this.btSendMessage.Location = new System.Drawing.Point(130, 368);
            this.btSendMessage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btSendMessage.MouseState = MaterialSkin.MouseState.HOVER;
            this.btSendMessage.Name = "btSendMessage";
            this.btSendMessage.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btSendMessage.Size = new System.Drawing.Size(130, 36);
            this.btSendMessage.TabIndex = 6;
            this.btSendMessage.Text = "Send Message";
            this.btSendMessage.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btSendMessage.UseAccentColor = false;
            this.btSendMessage.UseVisualStyleBackColor = true;
            this.btSendMessage.Click += new System.EventHandler(this.btSendMessage_Click);
            // 
            // tbUserSM
            // 
            this.tbUserSM.AnimateReadOnly = false;
            this.tbUserSM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbUserSM.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbUserSM.Depth = 0;
            this.tbUserSM.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbUserSM.HideSelection = true;
            this.tbUserSM.Hint = "Username";
            this.tbUserSM.LeadingIcon = null;
            this.tbUserSM.Location = new System.Drawing.Point(71, 70);
            this.tbUserSM.MaxLength = 32767;
            this.tbUserSM.MouseState = MaterialSkin.MouseState.OUT;
            this.tbUserSM.Name = "tbUserSM";
            this.tbUserSM.PasswordChar = '\0';
            this.tbUserSM.PrefixSuffixText = null;
            this.tbUserSM.ReadOnly = false;
            this.tbUserSM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbUserSM.SelectedText = "";
            this.tbUserSM.SelectionLength = 0;
            this.tbUserSM.SelectionStart = 0;
            this.tbUserSM.ShortcutsEnabled = true;
            this.tbUserSM.Size = new System.Drawing.Size(250, 48);
            this.tbUserSM.TabIndex = 4;
            this.tbUserSM.TabStop = false;
            this.tbUserSM.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbUserSM.TrailingIcon = null;
            this.tbUserSM.UseSystemPasswordChar = false;
            // 
            // tabChats
            // 
            this.tabChats.Controls.Add(this.materialCard3);
            this.tabChats.Location = new System.Drawing.Point(4, 22);
            this.tabChats.Name = "tabChats";
            this.tabChats.Padding = new System.Windows.Forms.Padding(3);
            this.tabChats.Size = new System.Drawing.Size(833, 472);
            this.tabChats.TabIndex = 1;
            this.tabChats.Text = "Chats";
            this.tabChats.Click += new System.EventHandler(this.tabContacts_Click);
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.btSendFile);
            this.materialCard3.Controls.Add(this.btSendChatMsg);
            this.materialCard3.Controls.Add(this.tbChatMsg);
            this.materialCard3.Controls.Add(this.flpChat);
            this.materialCard3.Controls.Add(this.flowLayoutPanel1);
            this.materialCard3.Depth = 0;
            this.materialCard3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(3, 3);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.materialCard3.Size = new System.Drawing.Size(827, 466);
            this.materialCard3.TabIndex = 2;
            this.materialCard3.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard3_Paint);
            // 
            // btSendFile
            // 
            this.btSendFile.AutoSize = false;
            this.btSendFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btSendFile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btSendFile.Depth = 0;
            this.btSendFile.DrawShadows = false;
            this.btSendFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSendFile.HighEmphasis = true;
            this.btSendFile.Icon = global::Proyecto1_Redes.Properties.Resources.attach_file;
            this.btSendFile.Location = new System.Drawing.Point(720, 402);
            this.btSendFile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btSendFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btSendFile.Name = "btSendFile";
            this.btSendFile.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btSendFile.Size = new System.Drawing.Size(44, 50);
            this.btSendFile.TabIndex = 14;
            this.btSendFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btSendFile.UseAccentColor = false;
            this.btSendFile.UseVisualStyleBackColor = true;
            this.btSendFile.Visible = false;
            // 
            // btSendChatMsg
            // 
            this.btSendChatMsg.AutoSize = false;
            this.btSendChatMsg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btSendChatMsg.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btSendChatMsg.Depth = 0;
            this.btSendChatMsg.DrawShadows = false;
            this.btSendChatMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSendChatMsg.HighEmphasis = true;
            this.btSendChatMsg.Icon = global::Proyecto1_Redes.Properties.Resources.send;
            this.btSendChatMsg.Location = new System.Drawing.Point(770, 402);
            this.btSendChatMsg.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btSendChatMsg.MouseState = MaterialSkin.MouseState.HOVER;
            this.btSendChatMsg.Name = "btSendChatMsg";
            this.btSendChatMsg.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btSendChatMsg.Size = new System.Drawing.Size(44, 50);
            this.btSendChatMsg.TabIndex = 13;
            this.btSendChatMsg.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btSendChatMsg.UseAccentColor = false;
            this.btSendChatMsg.UseVisualStyleBackColor = true;
            this.btSendChatMsg.Visible = false;
            this.btSendChatMsg.Click += new System.EventHandler(this.btSendChatMsg_Click);
            // 
            // tbChatMsg
            // 
            this.tbChatMsg.AnimateReadOnly = false;
            this.tbChatMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbChatMsg.Depth = 0;
            this.tbChatMsg.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbChatMsg.Hint = "Type message here...";
            this.tbChatMsg.LeadingIcon = null;
            this.tbChatMsg.Location = new System.Drawing.Point(298, 405);
            this.tbChatMsg.MaxLength = 3000;
            this.tbChatMsg.MouseState = MaterialSkin.MouseState.OUT;
            this.tbChatMsg.Multiline = false;
            this.tbChatMsg.Name = "tbChatMsg";
            this.tbChatMsg.Size = new System.Drawing.Size(417, 50);
            this.tbChatMsg.TabIndex = 2;
            this.tbChatMsg.Text = "";
            this.tbChatMsg.TrailingIcon = null;
            this.tbChatMsg.Visible = false;
            // 
            // flpChat
            // 
            this.flpChat.AutoScroll = true;
            this.flpChat.BackColor = System.Drawing.Color.Silver;
            this.flpChat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpChat.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpChat.Location = new System.Drawing.Point(298, 12);
            this.flpChat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flpChat.Name = "flpChat";
            this.flpChat.Size = new System.Drawing.Size(516, 387);
            this.flpChat.TabIndex = 1;
            this.flpChat.Visible = false;
            this.flpChat.WrapContents = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 12);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(283, 442);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // tabOthers
            // 
            this.tabOthers.Controls.Add(this.materialCard5);
            this.tabOthers.Controls.Add(this.materialCard4);
            this.tabOthers.Location = new System.Drawing.Point(4, 22);
            this.tabOthers.Name = "tabOthers";
            this.tabOthers.Padding = new System.Windows.Forms.Padding(3);
            this.tabOthers.Size = new System.Drawing.Size(833, 472);
            this.tabOthers.TabIndex = 3;
            this.tabOthers.Text = "Others";
            this.tabOthers.UseVisualStyleBackColor = true;
            // 
            // materialCard5
            // 
            this.materialCard5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.cmbRooms);
            this.materialCard5.Controls.Add(this.materialLabel3);
            this.materialCard5.Controls.Add(this.btsuscribeRoom);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(423, 17);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(393, 430);
            this.materialCard5.TabIndex = 8;
            // 
            // cmbRooms
            // 
            this.cmbRooms.AutoResize = false;
            this.cmbRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbRooms.Depth = 0;
            this.cmbRooms.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbRooms.DropDownHeight = 174;
            this.cmbRooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRooms.DropDownWidth = 121;
            this.cmbRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbRooms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbRooms.FormattingEnabled = true;
            this.cmbRooms.IntegralHeight = false;
            this.cmbRooms.ItemHeight = 43;
            this.cmbRooms.Location = new System.Drawing.Point(71, 191);
            this.cmbRooms.MaxDropDownItems = 4;
            this.cmbRooms.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbRooms.Name = "cmbRooms";
            this.cmbRooms.Size = new System.Drawing.Size(250, 49);
            this.cmbRooms.StartIndex = 0;
            this.cmbRooms.TabIndex = 8;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(109, 27);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(172, 19);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "Suscribe to a ChatRoom";
            // 
            // btsuscribeRoom
            // 
            this.btsuscribeRoom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btsuscribeRoom.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btsuscribeRoom.Depth = 0;
            this.btsuscribeRoom.HighEmphasis = true;
            this.btsuscribeRoom.Icon = null;
            this.btsuscribeRoom.Location = new System.Drawing.Point(151, 349);
            this.btsuscribeRoom.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btsuscribeRoom.MouseState = MaterialSkin.MouseState.HOVER;
            this.btsuscribeRoom.Name = "btsuscribeRoom";
            this.btsuscribeRoom.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btsuscribeRoom.Size = new System.Drawing.Size(89, 36);
            this.btsuscribeRoom.TabIndex = 6;
            this.btsuscribeRoom.Text = "Suscribe";
            this.btsuscribeRoom.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btsuscribeRoom.UseAccentColor = false;
            this.btsuscribeRoom.UseVisualStyleBackColor = true;
            this.btsuscribeRoom.Click += new System.EventHandler(this.btsuscribeRoom_Click);
            // 
            // materialCard4
            // 
            this.materialCard4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.materialLabel2);
            this.materialCard4.Controls.Add(this.btAddUser);
            this.materialCard4.Controls.Add(this.tbAddUser);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(17, 17);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(393, 430);
            this.materialCard4.TabIndex = 1;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(94, 27);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(194, 19);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "Add a user to your contacts";
            // 
            // btAddUser
            // 
            this.btAddUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btAddUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btAddUser.Depth = 0;
            this.btAddUser.HighEmphasis = true;
            this.btAddUser.Icon = null;
            this.btAddUser.Location = new System.Drawing.Point(151, 349);
            this.btAddUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btAddUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.btAddUser.Name = "btAddUser";
            this.btAddUser.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btAddUser.Size = new System.Drawing.Size(90, 36);
            this.btAddUser.TabIndex = 6;
            this.btAddUser.Text = "Add User";
            this.btAddUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btAddUser.UseAccentColor = false;
            this.btAddUser.UseVisualStyleBackColor = true;
            this.btAddUser.Click += new System.EventHandler(this.btAddUser_Click);
            // 
            // tbAddUser
            // 
            this.tbAddUser.AnimateReadOnly = false;
            this.tbAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbAddUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbAddUser.Depth = 0;
            this.tbAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbAddUser.HideSelection = true;
            this.tbAddUser.Hint = "Username";
            this.tbAddUser.LeadingIcon = null;
            this.tbAddUser.Location = new System.Drawing.Point(71, 191);
            this.tbAddUser.MaxLength = 32767;
            this.tbAddUser.MouseState = MaterialSkin.MouseState.OUT;
            this.tbAddUser.Name = "tbAddUser";
            this.tbAddUser.PasswordChar = '\0';
            this.tbAddUser.PrefixSuffixText = null;
            this.tbAddUser.ReadOnly = false;
            this.tbAddUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbAddUser.SelectedText = "";
            this.tbAddUser.SelectionLength = 0;
            this.tbAddUser.SelectionStart = 0;
            this.tbAddUser.ShortcutsEnabled = true;
            this.tbAddUser.Size = new System.Drawing.Size(250, 48);
            this.tbAddUser.TabIndex = 4;
            this.tbAddUser.TabStop = false;
            this.tbAddUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbAddUser.TrailingIcon = null;
            this.tbAddUser.UseSystemPasswordChar = false;
            // 
            // tabProfile
            // 
            this.tabProfile.Controls.Add(this.materialCard2);
            this.tabProfile.Location = new System.Drawing.Point(4, 22);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfile.Size = new System.Drawing.Size(833, 472);
            this.tabProfile.TabIndex = 2;
            this.tabProfile.Text = "Profile";
            this.tabProfile.UseVisualStyleBackColor = true;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.btSetPresenceMsg);
            this.materialCard2.Controls.Add(this.tbPresenceMsg);
            this.materialCard2.Controls.Add(this.cmbPresence);
            this.materialCard2.Controls.Add(this.pictureBox1);
            this.materialCard2.Controls.Add(this.btDeleteAcct);
            this.materialCard2.Controls.Add(this.btLogOut);
            this.materialCard2.Controls.Add(this.flowLayoutPanel2);
            this.materialCard2.Controls.Add(this.lbJid);
            this.materialCard2.Depth = 0;
            this.materialCard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(3, 3);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(827, 466);
            this.materialCard2.TabIndex = 0;
            // 
            // btSetPresenceMsg
            // 
            this.btSetPresenceMsg.AutoSize = false;
            this.btSetPresenceMsg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btSetPresenceMsg.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btSetPresenceMsg.Depth = 0;
            this.btSetPresenceMsg.DrawShadows = false;
            this.btSetPresenceMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSetPresenceMsg.HighEmphasis = true;
            this.btSetPresenceMsg.Icon = global::Proyecto1_Redes.Properties.Resources.cheque;
            this.btSetPresenceMsg.Location = new System.Drawing.Point(581, 274);
            this.btSetPresenceMsg.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btSetPresenceMsg.MouseState = MaterialSkin.MouseState.HOVER;
            this.btSetPresenceMsg.Name = "btSetPresenceMsg";
            this.btSetPresenceMsg.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btSetPresenceMsg.Size = new System.Drawing.Size(39, 50);
            this.btSetPresenceMsg.TabIndex = 12;
            this.btSetPresenceMsg.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btSetPresenceMsg.UseAccentColor = false;
            this.btSetPresenceMsg.UseVisualStyleBackColor = true;
            this.btSetPresenceMsg.Click += new System.EventHandler(this.btSetPresenceMsg_Click);
            // 
            // tbPresenceMsg
            // 
            this.tbPresenceMsg.AnimateReadOnly = false;
            this.tbPresenceMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPresenceMsg.Depth = 0;
            this.tbPresenceMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbPresenceMsg.Hint = "Message";
            this.tbPresenceMsg.LeadingIcon = null;
            this.tbPresenceMsg.Location = new System.Drawing.Point(378, 274);
            this.tbPresenceMsg.MaxLength = 50;
            this.tbPresenceMsg.MouseState = MaterialSkin.MouseState.OUT;
            this.tbPresenceMsg.Multiline = false;
            this.tbPresenceMsg.Name = "tbPresenceMsg";
            this.tbPresenceMsg.Size = new System.Drawing.Size(196, 50);
            this.tbPresenceMsg.TabIndex = 11;
            this.tbPresenceMsg.Text = "Ready to Chat";
            this.tbPresenceMsg.TrailingIcon = null;
            // 
            // cmbPresence
            // 
            this.cmbPresence.AutoResize = false;
            this.cmbPresence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbPresence.Depth = 0;
            this.cmbPresence.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbPresence.DropDownHeight = 174;
            this.cmbPresence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPresence.DropDownWidth = 121;
            this.cmbPresence.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbPresence.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbPresence.FormattingEnabled = true;
            this.cmbPresence.Hint = "Presence";
            this.cmbPresence.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbPresence.IntegralHeight = false;
            this.cmbPresence.ItemHeight = 43;
            this.cmbPresence.Items.AddRange(new object[] {
            "Available",
            "Away",
            "Unavailable",
            "Do Not Disturb"});
            this.cmbPresence.Location = new System.Drawing.Point(378, 218);
            this.cmbPresence.MaxDropDownItems = 4;
            this.cmbPresence.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbPresence.Name = "cmbPresence";
            this.cmbPresence.Size = new System.Drawing.Size(243, 49);
            this.cmbPresence.StartIndex = 0;
            this.cmbPresence.TabIndex = 10;
            this.cmbPresence.SelectedIndexChanged += new System.EventHandler(this.cmbPresence_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto1_Redes.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(438, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btDeleteAcct
            // 
            this.btDeleteAcct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btDeleteAcct.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btDeleteAcct.Depth = 0;
            this.btDeleteAcct.HighEmphasis = true;
            this.btDeleteAcct.Icon = null;
            this.btDeleteAcct.Location = new System.Drawing.Point(429, 395);
            this.btDeleteAcct.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btDeleteAcct.MouseState = MaterialSkin.MouseState.HOVER;
            this.btDeleteAcct.Name = "btDeleteAcct";
            this.btDeleteAcct.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btDeleteAcct.Size = new System.Drawing.Size(145, 36);
            this.btDeleteAcct.TabIndex = 8;
            this.btDeleteAcct.Text = "Delete Account";
            this.btDeleteAcct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btDeleteAcct.UseAccentColor = false;
            this.btDeleteAcct.UseVisualStyleBackColor = true;
            this.btDeleteAcct.Click += new System.EventHandler(this.btDeleteAcct_Click);
            // 
            // btLogOut
            // 
            this.btLogOut.AutoSize = false;
            this.btLogOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btLogOut.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btLogOut.Depth = 0;
            this.btLogOut.HighEmphasis = true;
            this.btLogOut.Icon = null;
            this.btLogOut.Location = new System.Drawing.Point(429, 341);
            this.btLogOut.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btLogOut.MouseState = MaterialSkin.MouseState.HOVER;
            this.btLogOut.Name = "btLogOut";
            this.btLogOut.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btLogOut.Size = new System.Drawing.Size(145, 36);
            this.btLogOut.TabIndex = 7;
            this.btLogOut.Text = "Log Out";
            this.btLogOut.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btLogOut.UseAccentColor = false;
            this.btLogOut.UseVisualStyleBackColor = true;
            this.btLogOut.Click += new System.EventHandler(this.btLogOut_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(14, 14);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(221, 438);
            this.flowLayoutPanel2.TabIndex = 6;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // lbJid
            // 
            this.lbJid.AutoSize = true;
            this.lbJid.Depth = 0;
            this.lbJid.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbJid.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lbJid.Location = new System.Drawing.Point(373, 168);
            this.lbJid.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbJid.Name = "lbJid";
            this.lbJid.Size = new System.Drawing.Size(263, 29);
            this.lbJid.TabIndex = 5;
            this.lbJid.Text = "mor21146@alumchat.lol";
            this.lbJid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbJid.Paint += new System.Windows.Forms.PaintEventHandler(this.lbJid_Paint);
            // 
            // MoraChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 565);
            this.Controls.Add(this.tcChat);
            this.DrawerTabControl = this.tcChat;
            this.Name = "MoraChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoraChat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmChat_FormClosing);
            this.Load += new System.EventHandler(this.frmChat_Load);
            this.tcChat.ResumeLayout(false);
            this.tabDM.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.tabChats.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            this.tabOthers.ResumeLayout(false);
            this.materialCard5.ResumeLayout(false);
            this.materialCard5.PerformLayout();
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            this.tabProfile.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tcChat;
        private System.Windows.Forms.TabPage tabDM;
        private System.Windows.Forms.TabPage tabChats;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btSendMessage;
        private MaterialSkin.Controls.MaterialTextBox2 tbUserSM;
        private System.Windows.Forms.TabPage tabProfile;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 tbMessageSM;
        private MaterialSkin.Controls.MaterialSwitch swGroupChatSM;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private MaterialSkin.Controls.MaterialLabel lbJid;
        private MaterialSkin.Controls.MaterialButton btDeleteAcct;
        private MaterialSkin.Controls.MaterialButton btLogOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialComboBox cmbPresence;
        private MaterialSkin.Controls.MaterialButton btSetPresenceMsg;
        private MaterialSkin.Controls.MaterialTextBox tbPresenceMsg;
        private System.Windows.Forms.TabPage tabOthers;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton btAddUser;
        private MaterialSkin.Controls.MaterialTextBox2 tbAddUser;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialComboBox cmbRooms;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton btsuscribeRoom;
        private System.Windows.Forms.FlowLayoutPanel flpChat;
        private MaterialSkin.Controls.MaterialButton btSendChatMsg;
        private MaterialSkin.Controls.MaterialTextBox tbChatMsg;
        private MaterialSkin.Controls.MaterialButton btSendFile;
    }
}