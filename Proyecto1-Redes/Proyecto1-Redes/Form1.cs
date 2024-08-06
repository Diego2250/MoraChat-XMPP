using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XmppDotNet;
using XmppDotNet.Extensions.Client.Message;
using XmppDotNet.Extensions.Client.Presence;
using XmppDotNet.Extensions.Client.Roster;
using XmppDotNet.Transport;
using XmppDotNet.Transport.Socket;

namespace Proyecto1_Redes
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btLogin_Click(object sender, EventArgs e)
        {
            string username = tbUser.Text;
            string password = tbPassword.Text;

            var xmppClient = new XmppClient(
                conf =>
                {
                    conf.UseSocketTransport();
                    conf.AutoReconnect = true;
                    conf.WithCertificateValidator(new AlwaysAcceptCertificateValidator());


                }
            )
            {
                Jid = username,
                Password = password
            };

            xmppClient.StateChanged
                .Where(s => s == SessionState.Binded)
                .Subscribe(async v =>
                {
                    var roster = await xmppClient.RequestRosterAsync();
                    await xmppClient.SendPresenceAsync(XmppDotNet.Xmpp.Show.Chat, "free for chat");
                    // send a chat message to user2
                    await xmppClient.SendChatMessageAsync("her21199@alumchat.lol", "This is a test");
                });

            try
            {
                await xmppClient.ConnectAsync();
                MessageBox.Show("Conectado con éxito");
                await xmppClient.DisconnectAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar: {ex.Message}");
            }
        }
    }
}
