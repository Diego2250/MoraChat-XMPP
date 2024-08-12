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
            this.lblLastMessage.Location = new System.Drawing.Point(94, 45);
            this.lblLastMessage.Name = "lblLastMessage";
            this.lblLastMessage.Size = new System.Drawing.Size(35, 13);
            this.lblLastMessage.TabIndex = 5;
            this.lblLastMessage.Text = "label2";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(93, 19);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 24);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "label1";
            // 
            // lbInitial
            // 
            this.lbInitial.AutoSize = true;
            this.lbInitial.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Underline);
            this.lbInitial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbInitial.Location = new System.Drawing.Point(16, 19);
            this.lbInitial.Name = "lbInitial";
            this.lbInitial.Size = new System.Drawing.Size(49, 46);
            this.lbInitial.TabIndex = 3;
            this.lbInitial.Text = "C";
            this.lbInitial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbInitial.Paint += new System.Windows.Forms.PaintEventHandler(this.lbInitial_Paint);
            // 
            // crlChatCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblLastMessage);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lbInitial);
            this.Name = "crlChatCard";
            this.Size = new System.Drawing.Size(318, 84);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLastMessage;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lbInitial;
    }
}
