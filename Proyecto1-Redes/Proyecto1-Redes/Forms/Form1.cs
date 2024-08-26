using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto1_Redes.Forms;
using XmppDotNet;
using XmppDotNet.Extensions.Client.Message;
using XmppDotNet.Extensions.Client.Presence;
using XmppDotNet.Extensions.Client.Roster;
using XmppDotNet.Transport;
using XmppDotNet.Transport.Socket;
using XmppDotNet.Transport.WebSocket;

namespace Proyecto1_Redes
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public SessionState SessionState;
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple900, Primary.Purple900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btLogin_Click(object sender, EventArgs e)
        {
            btLogin.Visible = false;
            pbLoading.Visible = true;

            string username = tbUser.Text + "@alumchat.lol";
            string password = tbPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                //MessageBox.Show("Enter a username and password");
                frmToasMessage toasMessage = new frmToasMessage("error", "Enter a username and password");
                toasMessage.Show();
                pbLoading.Visible = false;
                btLogin.Visible = true;
                return;
            }

            if (swCreateAcct.Checked)
            {
                await CreateAccount(username, password);
            }
            else
            {
                await Login(username, password);
            }
            pbLoading.Visible = false;
            btLogin.Visible = true;
        }





        private void swCreateAcct_CheckedChanged(object sender, EventArgs e)
        {
            btLogin.Text = swCreateAcct.Checked ? "Sign in" : "Login";
        }

        private async Task CreateAccount(string username, string password)
        {

            var xmppClient = new XmppClient(
                conf =>
                {
                    conf.UseSocketTransport();
                    //conf.AutoReconnect = true;
                    conf.WithCertificateValidator(new AlwaysAcceptCertificateValidator());
                }
            )
            {
                Jid = username,
                Password = password
            };
           
            
            // set our RegisterAccountHandler
            xmppClient.RegistrationHandler = new RegisterAccountHandler(xmppClient);

            try
            {
                await xmppClient.ConnectAsync();
                //MessageBox.Show("Account created successfully!");
                frmToasMessage toasMessage = new frmToasMessage("success", "Account created successfully!");
                toasMessage.Show();

                swCreateAcct.Checked = false;


            }
            catch (XmppDotNet.RegisterException e)
            {
                //MessageBox.Show($"Error while creating account: {e.Stanza.LastNode.ToString()}");
                frmToasMessage toasMessage = new frmToasMessage("error", "Error while creating account");
                toasMessage.Show();

            }

            return;
        }

        private async Task Login(string username, string password)
        {
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

            xmppClient
                .StateChanged
                .Where(s => s == SessionState.Binded)
                .Subscribe(async v =>
                {
                    var roster = await xmppClient.RequestRosterAsync();
                    //MessageBox.Show(roster.ToString());
                    await xmppClient.SendPresenceAsync(XmppDotNet.Xmpp.Show.Chat, "Ready to chat");
                });


            try
            {
                

                await xmppClient.ConnectAsync();
                //MessageBox.Show("Connection Successful!");
                MoraChat frmChat = new MoraChat(xmppClient);
                frmToasMessage toasMessage = new frmToasMessage("success", "Welcome to MoraChat!");
                toasMessage.Show();

                frmChat.Show();
                this.Hide();
            }
            catch (XmppException ex)
            {
                //MessageBox.Show($"Error while connecting: {ex.Stanza}");
                frmToasMessage toasMessage = new frmToasMessage("error", "Error while connecting");
                toasMessage.Show();
                pbLoading.Visible = false;
                btLogin.Visible = true;
                Console.WriteLine(ex.Stanza);
            }

            return;
        }


    }
}
