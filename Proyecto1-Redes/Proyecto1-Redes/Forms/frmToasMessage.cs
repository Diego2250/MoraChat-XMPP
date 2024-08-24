using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_Redes.Forms
{
    public partial class frmToasMessage : Form
    {
        private static List<frmToasMessage> activeToasts = new List<frmToasMessage>();
        String type, Message;
        int x, y;

        public frmToasMessage(String type, String Message)
        {
            InitializeComponent();
            this.type = type;
            this.Message = Message;
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.ShowInTaskbar = false;
            this.SendToBack();

        }

        private void frmToasMessage_Load(object sender, EventArgs e)
        {
            position();
            
        }

        private void frmToasMessage_Paint(object sender, PaintEventArgs e)
        {
            // Set the type to the label1
            label1.Text = type.ToUpperInvariant();

            // Set message to the label2
            label2.Text = Message;

            // If the type is "error" paint the panel1 red and load error icon to pictureBox1
            if (type == "error")
            {
                panel1.BackColor = Color.Red;
                pictureBox1.Image = Properties.Resources.erro;
            }
            else if (type == "success")
            {
                // If the type is "success" paint the panel1 green and load success icon to pictureBox1
                panel1.BackColor = Color.Green;
                pictureBox1.Image = Properties.Resources.success;
            }
            else if(type == "info")
            {
                // If the type is "info" paint the panel1 blue and load info icon to pictureBox1
                panel1.BackColor = Color.DodgerBlue;
                pictureBox1.Image = Properties.Resources.information;
            }
        }

        private void tmrHide_Tick(object sender, EventArgs e)
        {
            y += 5;
            this.Location = new Point(x, y);

            if (y >= Screen.PrimaryScreen.WorkingArea.Height)
            {
                tmrHide.Stop();
                this.Close();
            }
        }

        private void tmrWait_Tick(object sender, EventArgs e)
        {
            tmrWait.Stop();  // Detenemos el temporizador de espera
            tmrHide.Start(); // Inicia el ocultamiento
        }

        private void frmToasMessage_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void tmrToast_Tick(object sender, EventArgs e)
        {
            // Animate the form going up
            y -= 5;
            this.Location = new Point(x, y);

            if (y <= Screen.PrimaryScreen.WorkingArea.Height - this.Height - 10)
            {
                tmrToast.Stop();
                // Wait 3 seconds before hiding the form
                tmrWait.Start(); 
               
                
            }
        }

        private void position()
        {
            int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            x = ScreenWidth - this.Width - 10;
            y = ScreenHeight - this.Height + 70;

            // Set the position of the form to the top left corner of the screen
            this.Location = new Point(x, y);  
        }
    }
}
