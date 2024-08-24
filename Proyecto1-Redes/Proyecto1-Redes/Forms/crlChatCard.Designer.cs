namespace Proyecto1_Redes.Forms
{
    partial class crlChatCard
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLastMessage = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lbInitial = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblLastMessage
            // 
            this.lblLastMessage.AutoSize = true;
            this.lblLastMessage.Location = new System.Drawing.Point(91, 40);
            this.lblLastMessage.Name = "lblLastMessage";
            this.lblLastMessage.Size = new System.Drawing.Size(35, 13);
            this.lblLastMessage.TabIndex = 5;
            this.lblLastMessage.Text = "label2";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(89, 16);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(57, 20);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "label1";
            // 
            // lbInitial
            // 
            this.lbInitial.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInitial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbInitial.Location = new System.Drawing.Point(16, 12);
            this.lbInitial.Name = "lbInitial";
            this.lbInitial.Size = new System.Drawing.Size(67, 60);
            this.lbInitial.TabIndex = 3;
            this.lbInitial.Text = "C";
            this.lbInitial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbInitial.Paint += new System.Windows.Forms.PaintEventHandler(this.lbInitial_Paint);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbStatus.Location = new System.Drawing.Point(91, 57);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(47, 15);
            this.lbStatus.TabIndex = 6;
            this.lbStatus.Text = "label3";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(13, 90);
            this.panel1.TabIndex = 7;
            // 
            // crlChatCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lblLastMessage);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lbInitial);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "crlChatCard";
            this.Size = new System.Drawing.Size(190, 87);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.MouseEnter += new System.EventHandler(this.crlChatCard_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.crlChatCard_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLastMessage;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lbInitial;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Panel panel1;
    }
}
