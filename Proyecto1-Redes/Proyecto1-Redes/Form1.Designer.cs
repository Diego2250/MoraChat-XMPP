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
            this.btLogin = new MaterialSkin.Controls.MaterialButton();
            this.tbUser = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbPassword = new MaterialSkin.Controls.MaterialTextBox2();
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
            this.btLogin.Location = new System.Drawing.Point(324, 291);
            this.btLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btLogin.Name = "btLogin";
            this.btLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btLogin.Size = new System.Drawing.Size(153, 36);
            this.btLogin.TabIndex = 0;
            this.btLogin.Text = "Ingresar";
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
            this.tbUser.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbUser.HideSelection = true;
            this.tbUser.Hint = "Usuario";
            this.tbUser.LeadingIcon = null;
            this.tbUser.Location = new System.Drawing.Point(214, 139);
            this.tbUser.MaxLength = 32767;
            this.tbUser.MouseState = MaterialSkin.MouseState.OUT;
            this.tbUser.Name = "tbUser";
            this.tbUser.PasswordChar = '\0';
            this.tbUser.ReadOnly = false;
            this.tbUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbUser.SelectedText = "";
            this.tbUser.SelectionLength = 0;
            this.tbUser.SelectionStart = 0;
            this.tbUser.ShortcutsEnabled = true;
            this.tbUser.Size = new System.Drawing.Size(372, 48);
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
            this.tbPassword.Hint = "Contraseña";
            this.tbPassword.LeadingIcon = null;
            this.tbPassword.Location = new System.Drawing.Point(214, 205);
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
            this.tbPassword.Size = new System.Drawing.Size(372, 48);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.TabStop = false;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPassword.TrailingIcon = null;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.btLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.btLogin);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoraChat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btLogin;
        private MaterialSkin.Controls.MaterialTextBox2 tbUser;
        private MaterialSkin.Controls.MaterialTextBox2 tbPassword;
    }
}

