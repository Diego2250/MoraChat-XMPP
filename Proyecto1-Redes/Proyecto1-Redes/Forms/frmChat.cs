using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Reactive.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto1_Redes.Classes;
using XmppDotNet;
using XmppDotNet.Extensions.Client.Roster;
using XmppDotNet.Xml;
using XmppDotNet.Xmpp;
using XmppDotNet.Xmpp.Client;
using XmppDotNet.Xmpp.MessageArchiveManagement;
using XmppDotNet.Xmpp.ResultSetManagement;
using XmppDotNet.Xmpp.Roster;
using XmppDotNet.Xmpp.XData;
using XmppDotNet.Xmpp.Base;
using Iq = XmppDotNet.Xmpp.Base.Iq;
using RosterItem = XmppDotNet.Xmpp.Roster.RosterItem;
using Message = XmppDotNet.Xmpp.Base.Message;
using MaterialSkin;
using XmppDotNet.Extensions.Client.Message;
using System.Runtime.ConstrainedExecution;
using System.Xml;
using XmppDotNet.Extensions.Client.Presence;
using XmppDotNet.Extensions.Client.Disco;
using XmppDotNet.Xmpp.Muc;
using XmppDotNet.Extensions.Client.PubSub;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Jid = XmppDotNet.Jid;
using Presence = XmppDotNet.Xmpp.Base.Presence;

namespace Proyecto1_Redes.Forms
{
    public partial class MoraChat : MaterialSkin.Controls.MaterialForm
    {
        private List<string> roster = new List<string>();
        public XmppClient xmppClient;
        public MucManager MucManager;
        //Create a dictionary to store conversations
        private Dictionary<string, Dictionary<string, List<string>>> conversations_DM = new Dictionary<string, Dictionary<string, List<string>>>();


        public MoraChat(XmppClient XmppClient)
        {
            InitializeComponent();
            InitializeMaterialSkin();

            this.xmppClient = XmppClient;
            MucManager = new MucManager(xmppClient);

            // Llamar a la función asíncrona en el constructor
            LoadAsync();
        }

        private async void LoadAsync()
        {
            await getRooster();

            // Suscribirse a los eventos después de que getRooster haya terminado
            SubscribeToXmppEvents();
        }

        private void InitializeMaterialSkin()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple900, Primary.Purple900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void SubscribeToXmppEvents()
        {
            xmppClient
                .XmppXElementReceived
                .Where(el =>
                    el.OfType<Message>()
                    && el.Cast<Message>().Type == MessageType.Chat
                    && el.Cast<Message>().Body != null)
                .Subscribe(el =>
                {
                    // Código para manejar mensajes de chat
                    var message = el.Cast<Message>();
                    var from = message.From.ToString();
                    var user = from.Split('/')[0].Split('@')[0];
                    var body = message.Body;

                    if (!conversations_DM.ContainsKey(user))
                    {
                        conversations_DM[user] = new Dictionary<string, List<string>>();
                    }

                    if (!conversations_DM[user].ContainsKey(user))
                    {
                        conversations_DM[user][user] = new List<string>();
                    }

                    conversations_DM[user][user].Add(body);

                    flowLayoutPanel1.Invoke(new Action(() => Crate_ChatCard(user, body)));
                });

            xmppClient
                .XmppXElementReceived
                .Where(el =>
                    el.OfType<Message>()
                    && el.Cast<Message>().Type == MessageType.GroupChat
                    && el.Cast<Message>().Body != null)
                .Subscribe(el =>
                {
                    // Código para manejar mensajes de grupo
                    var message = el.Cast<Message>();
                    var from = message.From.ToString();
                    var room = from.Split('/')[0];
                    var user = from.Split('/')[1];
                    var body = message.Body;

                    if (!conversations_DM.ContainsKey(room))
                    {
                        conversations_DM[room] = new Dictionary<string, List<string>>();
                    }

                    if (!conversations_DM[room].ContainsKey(user))
                    {
                        conversations_DM[room][user] = new List<string>();
                    }

                    conversations_DM[room][user].Add(body);

                    flowLayoutPanel1.Invoke(new Action(() => Crate_ChatCard(room, body)));
                });

            xmppClient
                .XmppXElementReceived
                .Where(el =>
                    el.OfType<Presence>()
                    && (el.Cast<Presence>().Status != null
                    || el.Cast<Presence>().Type == PresenceType.Unavailable))
                .Subscribe(el =>
                {
                    if (el.Cast<Presence>().Type == PresenceType.Unavailable)
                    {
                        var from = el.Cast<Presence>().From.ToString();
                        var user = from.Split('@')[0];

                        var existingChatCard = flowLayoutPanel1.Controls
                            .Cast<crlChatCard>()
                            .FirstOrDefault(cc => cc.UserName == user);
                        if (existingChatCard != null)
                        {
                            existingChatCard.Status = "Unavailable";
                            existingChatCard.chatShow = "Unavailable";
                        }
                    }
                    else
                    {
                        var presence = el.Cast<Presence>();
                        var from = presence.From.ToString();
                        var user = from.Split('@')[0];
                        var status = presence.Status;
                        var chatShow = presence.Show.ToString();

                        if (chatShow == "None")
                        {
                            chatShow = "Chat";
                        }
                        var existingChatCard = flowLayoutPanel1.Controls
                            .Cast<crlChatCard>()
                            .FirstOrDefault(cc => cc.UserName == user);
                        if (existingChatCard != null)
                        {
                            existingChatCard.Status = status;
                            existingChatCard.chatShow = chatShow;
                        }
                    }
                   
                });

            xmppClient
                .XmppXElementReceived
                .Subscribe(el =>
                {
                    Console.WriteLine(el.ToString());
                });
        }


        private async Task getRooster()
        {
            // request the roster from the server
            var rosterIqResult = await xmppClient.RequestRosterAsync();

            var RoomId = new Jid("apolito@conference.alumchat.lol");

            await MucManager.EnterRoomAsync(RoomId, "Mora");

            // get all rosterItems (list of contacts)
            var rosterItems = rosterIqResult.Query.Cast<Roster>().GetRoster();

            // enumerate over the items and build your contact list or GUI
            foreach (var ri in rosterItems)
            {
                // Save the Jids
                // You can use this to send messages to the contact
                // or to request the vCard of the contact
                roster.Add(ri.Jid);

                //Create a chatcard for each contact with the last message as "Start Chatting!"
                flowLayoutPanel1.Controls.Add(new crlChatCard(ri.Jid.Local, "Start Chatting!"));
            }

            //add self to chat cards
            flowLayoutPanel1.Controls.Add(new crlChatCard(xmppClient.Jid.Local, "Start Chatting!"));
        }

        private void Crate_ChatCard(string UserName, String LastMessage)
        {
            // verify if the chat card already exists
            var existingChatCard = flowLayoutPanel1.Controls
                .Cast<crlChatCard>()
                .FirstOrDefault(cc => cc.UserName == UserName);
            if (existingChatCard != null)
            {
                // update the chat card
                existingChatCard.LastMessage = LastMessage;
            }
            else
            {
                
                var chatCard = new crlChatCard(UserName, LastMessage);
                // add the chat card
                flowLayoutPanel1.Controls.Add(chatCard);
            }
            
        }
        private void frmChat_Load(object sender, EventArgs e)
        {
            lbJid.Text = xmppClient.Jid.ToString();
            
        }

        private async void frmChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            await xmppClient.DisconnectAsync();
            Form1 frmLogin = new Form1();
            frmLogin.Show();
        }

        private void tabDM_Click(object sender, EventArgs e)
        {

        }

        private async void btSendMessage_Click(object sender, EventArgs e)
        {
            try
            {
                string user = "";
                if (swGroupChatSM.Checked)
                {
                    user = tbUserSM.Text;

                }
                else
                {
                    user = tbUserSM.Text + "@alumchat.lol";
                }

                String message = tbMessageSM.Text;
                if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(message))
                {
                    MessageBox.Show("Enter a username and message");
                    return;
                }
                // send a chat message
                await xmppClient.SendChatMessageAsync(user, message);
                MessageBox.Show("Message sent");
                tbUserSM.Text = "";
                tbMessageSM.Text = "";

            }
            catch (XmppException ex)
            {
                MessageBox.Show(ex.Stanza.Value);
            }

        }


        private void tcChat_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void tcChat_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabContacts_Click(object sender, EventArgs e)
        {

        }

        private async void tcChat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcChat.SelectedTab == tabDM)
            {
            }
            else if (tcChat.SelectedTab == tabChats)
            {
            }
            else if (tcChat.SelectedTab == tabProfile)
            {
                

            }
        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void materialCard3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btDeleteAcct_Click(object sender, EventArgs e)
        {
            
        }

        private void lbInitial_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbJid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbPresence_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Available
            // Away
            // Unavailable
            // Do Not Disturb

            if (cmbPresence.SelectedIndex == 0) {
                xmppClient.SendPresenceAsync(XmppDotNet.Xmpp.Show.Chat, tbPresenceMsg.Text);
            }
            else if (cmbPresence.SelectedIndex == 1)
            {
                xmppClient.SendPresenceAsync(XmppDotNet.Xmpp.Show.Away, tbPresenceMsg.Text);
            }
            else if (cmbPresence.SelectedIndex == 2)
            {
                xmppClient.SendPresenceAsync(XmppDotNet.Xmpp.Show.ExtendedAway, tbPresenceMsg.Text);

            }
            else if (cmbPresence.SelectedIndex == 3)
            {
                xmppClient.SendPresenceAsync(XmppDotNet.Xmpp.Show.DoNotDisturb, tbPresenceMsg.Text);
                
            }
        }

        private void btSetPresenceMsg_Click(object sender, EventArgs e)
        {
            int index = cmbPresence.SelectedIndex;
            string msg = tbPresenceMsg.Text;
            if (index == 0)
            {
                xmppClient.SendPresenceAsync(XmppDotNet.Xmpp.Show.Chat, msg);
            }
            else if (index == 1)
            {
                xmppClient.SendPresenceAsync(XmppDotNet.Xmpp.Show.Away, msg);
            }
            else if (index == 2)
            {
                xmppClient.SendPresenceAsync(XmppDotNet.Xmpp.Show.ExtendedAway, msg);

            }
            else if (index == 3)
            {
                xmppClient.SendPresenceAsync(XmppDotNet.Xmpp.Show.DoNotDisturb, msg);

            }
        }

        private async void btAddUser_Click(object sender, EventArgs e)
        {
            // Add user to contacts
            try
            {
                string user = tbAddUser.Text;
                if (string.IsNullOrEmpty(user))
                {
                    frmToasMessage toasMessage = new frmToasMessage("error", "Enter a username");
                    toasMessage.Show();
                    return;
                }

                await xmppClient.AddRosterItemAsync(user);

                frmToasMessage toasMessage1 = new frmToasMessage("success", "User added to contacts");
                toasMessage1.Show();
            }
            catch (Exception xmException)
            {
                frmToasMessage toasMessage = new frmToasMessage("error", xmException.Message);
                toasMessage.Show();
                Console.WriteLine(xmException.Message);
                throw;
            }
            

            
        }
    }
}
