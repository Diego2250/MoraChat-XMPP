using Proyecto1_Redes.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XmppDotNet;
using XmppDotNet.Extensions.Client.Subscription;

namespace Proyecto1_Redes.Forms
{
    public partial class crlNotification : UserControl
    {
        XmppClient xmppClient;

        string userName, msg, type, roomJid;

        FlowLayoutPanel parentPanel; // Referencia al FlowLayoutPanel

        private MucManager MucManager;

        public crlNotification(string userName, string msg, string type, XmppClient xmppClient, FlowLayoutPanel parentPanel, string roomJid = "")
        {
            InitializeComponent();
            this.xmppClient = xmppClient;
            this.userName = userName;
            this.msg = msg;
            this.roomJid = roomJid;
            this.type = type;
            this.parentPanel = parentPanel;
            MucManager = new MucManager(xmppClient);
        }

        private void RemoveControl()
        {
            if (parentPanel != null)
            {
                parentPanel.Controls.Remove(this);
                this.Dispose();
            }
        }

        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            if (type == "subscription")
            {
                await xmppClient.ApproveSubscriptionRequestAsync(userName + "@alumchat.lol");
                RemoveControl();
                frmToasMessage toasMessage = new frmToasMessage("info", "Subscription request approved");
                toasMessage.Show();
            }

            if (type == "group invitation")
            {
                var roomId = new Jid(roomJid);

                await MucManager.EnterRoomAsync(roomId, xmppClient.Jid.Local);


                RemoveControl();
                frmToasMessage toasMessage = new frmToasMessage("info", "Invitation to room approved!");
                toasMessage.Show();
            }
        }

        private void crlNotification_Enter(object sender, EventArgs e)
        {
            
        }

        private void crlNotification_Leave(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = ColorTranslator.FromHtml("#505050");
        }

        private void crlNotification_MouseEnter(object sender, EventArgs e)
        {
            // Cambiar el color de fondo a HEX: 817f7f y borde cuando el mouse entra
            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = ColorTranslator.FromHtml("#817f7f");

            // Opcional: puedes animar una transición
            var animationTimer = new Timer();
            animationTimer.Interval = 10; // Tiempo entre cada frame de la animación
            int steps = 10;
            int currentStep = 0;

            animationTimer.Tick += (s, args) =>
            {
                currentStep++;
                //this.Height += 2;

                if (currentStep >= steps)
                {
                    animationTimer.Stop();
                    animationTimer.Dispose();
                }
            };
            animationTimer.Start();
        }

        private void crlNotification_MouseLeave(object sender, EventArgs e)
        {
            // Restaurar el color de fondo a HEX #505050 y borde cuando el mouse sale
            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = ColorTranslator.FromHtml("#505050");

            // Restaurar tamaño si cambió
            var animationTimer = new Timer();
            animationTimer.Interval = 10; // Tiempo entre cada frame de la animación
            int steps = 10;
            int currentStep = 0;

            animationTimer.Tick += (s, args) =>
            {
                currentStep++;
                //this.Height -= 2;

                if (currentStep >= steps)
                {
                    animationTimer.Stop();
                    animationTimer.Dispose();
                }
            };
            animationTimer.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (type == "subscription")
            {
                xmppClient.DenySubscriptionRequestAsync(userName + "@alumchat.lol");
                RemoveControl();
                frmToasMessage toasMessage = new frmToasMessage("info", "Subscription request denied");
                toasMessage.Show();
            }

            if (type == "group invitation")
            {
                RemoveControl();
                frmToasMessage toasMessage = new frmToasMessage("info", "Invitation to room denied");
                toasMessage.Show();
            }
        }

        private void crlNotification_Load(object sender, EventArgs e)
        {
            lblUserName.Text = "From: " + userName;
            lblMessage.Text = msg;
            if (type == "unsubscribed" || type == "subscribed")
            {
                pbAccept.Enabled = false;
                pbAccept.Visible = false;
                pbDeny.Enabled = false;
                pbDeny.Visible = false;
            }
        }
    }
    
}
