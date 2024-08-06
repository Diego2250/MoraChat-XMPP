namespace Proyecto1_Redes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btLogin = new MaterialSkin.Controls.MaterialButton();
            this.tbUser = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbPassword = new MaterialSkin.Controls.MaterialTextBox2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.swCreateAcct = new MaterialSkin.Controls.MaterialSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btLogin
            // 
            this.btLogin.AutoSize = false;
            this.btLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btLogin.Depth = 0;
            this.btLogin.HighEmphasis = true;
            this.btLogin.Icon = null;
            this.btLogin.Location = new System.Drawing.Point(186, 331);
            this.btLogin.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btLogin.Name = "btLogin";
            this.btLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btLogin.Size = new System.Drawing.Size(115, 29);
            this.btLogin.TabIndex = 0;
            this.btLogin.Text = "Login";
            this.btLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btLogin.UseAccentColor = false;
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // tbUser
            // 
            this.tbUser.AnimateReadOnly = false;
            this.tbUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbUser.Depth = 0;
            this.tbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbUser.HideSelection = true;
            this.tbUser.Hint = "User";
            this.tbUser.LeadingIcon = null;
            this.tbUser.Location = new System.Drawing.Point(104, 185);
            this.tbUser.Margin = new System.Windows.Forms.Padding(2);
            this.tbUser.MaxLength = 32767;
            this.tbUser.MouseState = MaterialSkin.MouseState.OUT;
            this.tbUser.Name = "tbUser";
            this.tbUser.PasswordChar = '\0';
            this.tbUser.PrefixSuffixText = null;
            this.tbUser.ReadOnly = false;
            this.tbUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbUser.SelectedText = "";
            this.tbUser.SelectionLength = 0;
            this.tbUser.SelectionStart = 0;
            this.tbUser.ShortcutsEnabled = true;
            this.tbUser.Size = new System.Drawing.Size(279, 48);
            this.tbUser.TabIndex = 1;
            this.tbUser.TabStop = false;
            this.tbUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbUser.TrailingIcon = null;
            this.tbUser.UseSystemPasswordChar = false;
            // 
            // tbPassword
            // 
            this.tbPassword.AnimateReadOnly = false;
            this.tbPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbPassword.Depth = 0;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbPassword.HideSelection = true;
            this.tbPassword.Hint = "Password";
            this.tbPassword.LeadingIcon = null;
            this.tbPassword.Location = new System.Drawing.Point(104, 239);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword.MaxLength = 32767;
            this.tbPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '●';
            this.tbPassword.PrefixSuffixText = null;
            this.tbPassword.ReadOnly = false;
            this.tbPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbPassword.SelectedText = "";
            this.tbPassword.SelectionLength = 0;
            this.tbPassword.SelectionStart = 0;
            this.tbPassword.ShortcutsEnabled = true;
            this.tbPassword.Size = new System.Drawing.Size(279, 48);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.TabStop = false;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPassword.TrailingIcon = null;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(139, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // swCreateAcct
            // 
            this.swCreateAcct.AutoSize = true;
            this.swCreateAcct.Depth = 0;
            this.swCreateAcct.Location = new System.Drawing.Point(155, 289);
            this.swCreateAcct.Margin = new System.Windows.Forms.Padding(0);
            this.swCreateAcct.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swCreateAcct.MouseState = MaterialSkin.MouseState.HOVER;
            this.swCreateAcct.Name = "swCreateAcct";
            this.swCreateAcct.Ripple = true;
            this.swCreateAcct.Size = new System.Drawing.Size(172, 37);
            this.swCreateAcct.TabIndex = 7;
            this.swCreateAcct.Text = "Create account?";
            this.swCreateAcct.UseVisualStyleBackColor = true;
            this.swCreateAcct.CheckedChanged += new System.EventHandler(this.swCreateAcct_CheckedChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.btLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 397);
            this.Controls.Add(this.swCreateAcct);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.btLogin);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(2, 20, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoraChat";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btLogin;
        private MaterialSkin.Controls.MaterialTextBox2 tbUser;
        private MaterialSkin.Controls.MaterialTextBox2 tbPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSwitch swCreateAcct;
    }
}

