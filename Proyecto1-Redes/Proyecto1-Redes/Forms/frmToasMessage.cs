using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_Redes.Forms
{
    public partial class frmToasMessage : Form
    {
        String type, Message;

        public frmToasMessage(String type, String Message)
        {
            InitializeComponent();
            this.type = type;
            this.Message = Message;
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
            else {
                // If the type is "success" paint the panel1 green and load success icon to pictureBox1
                panel1.BackColor = Color.Green;
                pictureBox1.Image = Properties.Resources.success;
            }
        }

        private void position()
        {
            int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            // Set the position of the form to the top left corner of the screen
            this.Location = new Point(ScreenWidth - this.Width - 10, ScreenHeight - this.Height - 10);  
        }
    }
}
