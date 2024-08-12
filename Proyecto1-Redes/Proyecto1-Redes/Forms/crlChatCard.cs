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
    public partial class crlChatCard : UserControl
    {
        string UserName;
        string LastMessage;
        public crlChatCard(String UserName, string LastMessage)
        {
            InitializeComponent();
            this.UserName = UserName;
            this.LastMessage = LastMessage;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            lblLastMessage.Text = LastMessage;
            lblUserName.Text = UserName;
        }

        private void lbInitial_Paint(object sender, PaintEventArgs e)
        {
            lbInitial.Text = UserName.Substring(0, 1).ToUpper();
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, lbInitial.Width, lbInitial.Height);

            this.lbInitial.Region = new Region(path);
        }
    }
}
