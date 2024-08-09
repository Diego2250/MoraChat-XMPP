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
    public partial class frmChatCard : Form
    {
        public frmChatCard()
        {
            InitializeComponent();
        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, lbInitial.Width, lbInitial.Height);

            this.lbInitial.Region = new Region(path);
        }

        private void frmChatCard_Load(object sender, EventArgs e)
        {

        }
    }
}
