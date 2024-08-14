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
            this.SuspendLayout();
            // 
            // lblLastMessage
            // 
            this.lblLastMessage.AutoSize = true;
            this.lblLastMessage.Location = new System.Drawing.Point(135, 69);
            this.lblLastMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastMessage.Name = "lblLastMessage";
            this.lblLastMessage.Size = new System.Drawing.Size(51, 20);
            this.lblLastMessage.TabIndex = 5;
            this.lblLastMessage.Text = "label2";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(134, 29);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(79, 29);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "label1";
            // 
            // lbInitial
            // 
            this.lbInitial.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInitial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbInitial.Location = new System.Drawing.Point(24, 19);
            this.lbInitial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInitial.Name = "lbInitial";
            this.lbInitial.Size = new System.Drawing.Size(89, 81);
            this.lbInitial.TabIndex = 3;
            this.lbInitial.Text = "C";
            this.lbInitial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbInitial.Paint += new System.Windows.Forms.PaintEventHandler(this.lbInitial_Paint);
            // 
            // crlChatCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblLastMessage);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lbInitial);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "crlChatCard";
            this.Size = new System.Drawing.Size(385, 119);
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
    }
}
