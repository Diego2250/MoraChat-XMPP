namespace Proyecto1_Redes.Forms
{
    partial class crlNotification
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pbDeny = new System.Windows.Forms.PictureBox();
            this.pbAccept = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAccept)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(10, 41);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(35, 13);
            this.lblMessage.TabIndex = 9;
            this.lblMessage.Text = "label2";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(9, 12);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(57, 20);
            this.lblUserName.TabIndex = 8;
            this.lblUserName.Text = "label1";
            // 
            // pbDeny
            // 
            this.pbDeny.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDeny.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDeny.Image = global::Proyecto1_Redes.Properties.Resources.cancel;
            this.pbDeny.Location = new System.Drawing.Point(185, 42);
            this.pbDeny.Name = "pbDeny";
            this.pbDeny.Size = new System.Drawing.Size(29, 24);
            this.pbDeny.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDeny.TabIndex = 11;
            this.pbDeny.TabStop = false;
            this.pbDeny.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pbAccept
            // 
            this.pbAccept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAccept.Image = global::Proyecto1_Redes.Properties.Resources.cheque;
            this.pbAccept.Location = new System.Drawing.Point(185, 12);
            this.pbAccept.Name = "pbAccept";
            this.pbAccept.Size = new System.Drawing.Size(29, 24);
            this.pbAccept.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAccept.TabIndex = 10;
            this.pbAccept.TabStop = false;
            this.pbAccept.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // crlNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pbDeny);
            this.Controls.Add(this.pbAccept);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblUserName);
            this.Name = "crlNotification";
            this.Size = new System.Drawing.Size(215, 76);
            this.Load += new System.EventHandler(this.crlNotification_Load);
            this.Enter += new System.EventHandler(this.crlNotification_Enter);
            this.Leave += new System.EventHandler(this.crlNotification_Leave);
            this.MouseEnter += new System.EventHandler(this.crlNotification_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.crlNotification_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pbDeny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAccept)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox pbAccept;
        private System.Windows.Forms.PictureBox pbDeny;
    }
}
