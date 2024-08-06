using MaterialSkin;
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
    public partial class CustomMessageBox : MaterialSkin.Controls.MaterialForm
    {
        public CustomMessageBox()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple900, Primary.Purple900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void CustomMessageBox_Load(object sender, EventArgs e)
        {

        }

        public void msgShow(string message)
        {
            lbMsgBox.Text = message;
            pbMsgBox.Value = 0;
            pbMsgBox.Maximum = 100;
            this.Show();
            
            // increment the progress bar every 100 milliseconds
            for (int i = 0; i < 100; i++)
            {
                pbMsgBox.Value++;
                System.Threading.Thread.Sleep(100);
            }

            // Close the form
            this.Close();
        }
    }
}
