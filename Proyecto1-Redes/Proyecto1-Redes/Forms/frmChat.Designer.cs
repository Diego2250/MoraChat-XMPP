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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btSendMessage = new MaterialSkin.Controls.MaterialButton();
            this.tbMessageSM = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbUserSM = new MaterialSkin.Controls.MaterialTextBox2();
            this.tabContacts = new System.Windows.Forms.TabPage();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.tcChat.SuspendLayout();
            this.tabDM.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.tabProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcChat
            // 
            this.tcChat.Controls.Add(this.tabDM);
            this.tcChat.Controls.Add(this.tabContacts);
            this.tcChat.Controls.Add(this.tabProfile);
            this.tcChat.Depth = 0;
            this.tcChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcChat.Location = new System.Drawing.Point(3, 64);
            this.tcChat.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcChat.Multiline = true;
            this.tcChat.Name = "tcChat";
            this.tcChat.SelectedIndex = 0;
            this.tcChat.Size = new System.Drawing.Size(794, 383);
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
            this.tabDM.Size = new System.Drawing.Size(786, 357);
            this.tabDM.TabIndex = 0;
            this.tabDM.Text = "Direct Message";
            this.tabDM.UseVisualStyleBackColor = true;
            this.tabDM.Click += new System.EventHandler(this.tabDM_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.btSendMessage);
            this.materialCard1.Controls.Add(this.tbMessageSM);
            this.materialCard1.Controls.Add(this.tbUserSM);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(198, 17);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(390, 326);
            this.materialCard1.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(86, 33);
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
            this.btSendMessage.Location = new System.Drawing.Point(120, 256);
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
            // tbMessageSM
            // 
            this.tbMessageSM.AnimateReadOnly = false;
            this.tbMessageSM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbMessageSM.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbMessageSM.Depth = 0;
            this.tbMessageSM.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbMessageSM.HideSelection = true;
            this.tbMessageSM.Hint = "Message";
            this.tbMessageSM.LeadingIcon = null;
            this.tbMessageSM.Location = new System.Drawing.Point(70, 165);
            this.tbMessageSM.MaxLength = 32767;
            this.tbMessageSM.MouseState = MaterialSkin.MouseState.OUT;
            this.tbMessageSM.Name = "tbMessageSM";
            this.tbMessageSM.PasswordChar = '\0';
            this.tbMessageSM.PrefixSuffixText = null;
            this.tbMessageSM.ReadOnly = false;
            this.tbMessageSM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbMessageSM.SelectedText = "";
            this.tbMessageSM.SelectionLength = 0;
            this.tbMessageSM.SelectionStart = 0;
            this.tbMessageSM.ShortcutsEnabled = true;
            this.tbMessageSM.Size = new System.Drawing.Size(250, 48);
            this.tbMessageSM.TabIndex = 5;
            this.tbMessageSM.TabStop = false;
            this.tbMessageSM.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbMessageSM.TrailingIcon = null;
            this.tbMessageSM.UseSystemPasswordChar = false;
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
            this.tbUserSM.Location = new System.Drawing.Point(70, 76);
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
            // tabContacts
            // 
            this.tabContacts.Location = new System.Drawing.Point(4, 22);
            this.tabContacts.Name = "tabContacts";
            this.tabContacts.Padding = new System.Windows.Forms.Padding(3);
            this.tabContacts.Size = new System.Drawing.Size(786, 357);
            this.tabContacts.TabIndex = 1;
            this.tabContacts.Text = "Contacts";
            this.tabContacts.UseVisualStyleBackColor = true;
            this.tabContacts.Click += new System.EventHandler(this.tabContacts_Click);
            // 
            // tabProfile
            // 
            this.tabProfile.Controls.Add(this.materialCard2);
            this.tabProfile.Location = new System.Drawing.Point(4, 22);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfile.Size = new System.Drawing.Size(786, 357);
            this.tabProfile.TabIndex = 2;
            this.tabProfile.Text = "Profile";
            this.tabProfile.UseVisualStyleBackColor = true;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(14, 14);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(758, 333);
            this.materialCard2.TabIndex = 0;
            // 
            // MoraChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcChat);
            this.DrawerTabControl = this.tcChat;
            this.Name = "MoraChat";
            this.Text = "MoraChat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmChat_FormClosing);
            this.Load += new System.EventHandler(this.frmChat_Load);
            this.tcChat.ResumeLayout(false);
            this.tabDM.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.tabProfile.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tcChat;
        private System.Windows.Forms.TabPage tabDM;
        private System.Windows.Forms.TabPage tabContacts;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btSendMessage;
        private MaterialSkin.Controls.MaterialTextBox2 tbMessageSM;
        private MaterialSkin.Controls.MaterialTextBox2 tbUserSM;
        private System.Windows.Forms.TabPage tabProfile;
        private MaterialSkin.Controls.MaterialCard materialCard2;
    }
}