namespace Proyecto1_Redes.Forms
{
    partial class CustomMessageBox
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
            this.components = new System.ComponentModel.Container();
            this.pbMsgBox = new MaterialSkin.Controls.MaterialProgressBar();
            this.lbMsgBox = new MaterialSkin.Controls.MaterialLabel();
            this.tmrMsgBox = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pbMsgBox
            // 
            this.pbMsgBox.Depth = 0;
            this.pbMsgBox.Location = new System.Drawing.Point(0, 142);
            this.pbMsgBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.pbMsgBox.Name = "pbMsgBox";
            this.pbMsgBox.Size = new System.Drawing.Size(429, 5);
            this.pbMsgBox.TabIndex = 0;
            // 
            // lbMsgBox
            // 
            this.lbMsgBox.AutoSize = true;
            this.lbMsgBox.Depth = 0;
            this.lbMsgBox.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbMsgBox.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lbMsgBox.Location = new System.Drawing.Point(135, 64);
            this.lbMsgBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbMsgBox.Name = "lbMsgBox";
            this.lbMsgBox.Size = new System.Drawing.Size(160, 29);
            this.lbMsgBox.TabIndex = 1;
            this.lbMsgBox.Text = "materialLabel1";
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 157);
            this.Controls.Add(this.lbMsgBox);
            this.Controls.Add(this.pbMsgBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "CustomMessageBox";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Text = "CustomMessageBox";
            this.Load += new System.EventHandler(this.CustomMessageBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialProgressBar pbMsgBox;
        private MaterialSkin.Controls.MaterialLabel lbMsgBox;
        private System.Windows.Forms.Timer tmrMsgBox;
    }
}