﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Reactive.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
using MaterialSkin.Controls;
using Matrix.Xmpp.Client;
using XmppDotNet.Extensions.Client.Presence;
using XmppDotNet.Extensions.Client.Disco;
using XmppDotNet.Xmpp.Muc;
using XmppDotNet.Extensions.Client.PubSub;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Jid = XmppDotNet.Jid;
using MucManager = Proyecto1_Redes.Classes.MucManager;
using Presence = XmppDotNet.Xmpp.Base.Presence;
using XmppClient = XmppDotNet.XmppClient;
using Matrix.Xml;
using Matrix.Xmpp.HttpUpload;
using DiscoInfoIq = Matrix.Xmpp.Client.DiscoInfoIq;
using DiscoItemsIq = XmppDotNet.Xmpp.Client.DiscoItemsIq;
using Item = XmppDotNet.Xmpp.Muc.Item;

namespace Proyecto1_Redes.Forms
{
    public partial class MoraChat : MaterialSkin.Controls.MaterialForm
    {
        private List<string> roster = new List<string>();
        public XmppClient xmppClient;
        public MucManager MucManager;
        private string currectChat;

        //Create a dictionary to store conversations
        private Dictionary<string, List<List<string>>> conversations_DM = new Dictionary<string, List<List<string>>>();


        public MoraChat(XmppClient XmppClient)
        {
            this.xmppClient = XmppClient;

            // create a custom stanza to get rooms
            // this is a custom stanza to get the rooms

            LoadAsync();

            xmppClient
                .XmppXElementReceived
                .Where(el =>
                    el.OfType<Message>()
                    && el.Cast<Message>().Body != null)
                .Subscribe(el =>
                {
                    // Código para manejar mensajes de chat
                    if (el.Cast<Message>().Type == MessageType.Chat)
                    {
                        var message = el.Cast<Message>();
                        var from = message.From.ToString();
                        var user = from.Split('/')[0].Split('@')[0];
                        var body = message.Body;

                        if (!conversations_DM.ContainsKey(user))
                        {
                            conversations_DM[user] = new List<List<string>>();
                        }


                        conversations_DM[user].Add(new List<string> { user, body });

                        flowLayoutPanel1.Invoke(new Action(() => Crate_ChatCard(user, body)));
                        if (currectChat == user)
                        {
                            if (user == xmppClient.Jid.Local)
                            {
                                AddMessageToChat(body, true);
                            }
                            else
                            {
                                AddMessageToChat(body, false, user);
                            }
                        }

                        // Mostrar frmToasMessage en el hilo de la interfaz de usuario
                        this.Invoke(new Action(() =>
                        {
                            frmToasMessage toasMessage = new frmToasMessage("info", "New Message from " + user + "!");
                            toasMessage.Show();
                        }));
                    }

                    if (el.Cast<Message>().Type == MessageType.GroupChat)
                    {
                        var message = el.Cast<Message>();
                        var from = message.From.ToString();
                        var room = from.Split('/')[0];
                        var user = from.Split('/')[1];
                        var body = message.Body;

                        if (!conversations_DM.ContainsKey(room))
                        {
                            conversations_DM[room] = new List<List<string>>();
                        }

                        conversations_DM[room].Add(new List<string> { user, body });

                        flowLayoutPanel1.Invoke(new Action(() => Crate_ChatCard(room, body)));
                        if (currectChat == room)
                        {
                            if (user == xmppClient.Jid.Local)
                            {
                                AddMessageToChat(body, true);
                            }
                            else
                            {
                                AddMessageToChat(body, false, user);
                            }
                        }
                    }
                   
                });


            xmppClient
                .XmppXElementReceived
                .Where(el =>
                    el.OfType<Presence>()
                    && el.Cast<Presence>().Type != PresenceType.Error)
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

                        if (status == null)
                        {
                            status = "Available";
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

            InitializeComponent();
            InitializeMaterialSkin();

            MucManager = new MucManager(xmppClient);
            
        }

        private async void LoadAsync()
        {
            var rommIq = new DiscoItemsIq{Type = IqType.Get, To = new Jid("conference.alumchat.lol"),
                From = xmppClient.Jid, Id = "disco_1"};


            var discoItems = await xmppClient.SendIqAsync(rommIq);

            
            if (discoItems.Type == IqType.Result)
            {
                var items = discoItems.Query.Nodes().Cast<XmppDotNet.Xmpp.Disco.Item>();
                foreach (var item in items)
                {
                    // add jid to the list in combobox cmbRooms
                    cmbRooms.Items.Add(item.Jid);
                }
                cmbRooms.SelectedIndex = 0;
            }

            


            await getRooster();


            
        }

        private void InitializeMaterialSkin()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple900, Primary.Purple900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }


        private async Task getRooster()
        {
            // request the roster from the server
            var rosterIqResult = await xmppClient.RequestRosterAsync();
            

            
            // get all rosterItems (list of contacts)
            var rosterItems = rosterIqResult.Query.Cast<Roster>().GetRoster();

            // enumerate over the items and build your contact list or GUI
            foreach (var ri in rosterItems)
            {
                // Save the Jids
                // You can use this to send messages to the contact
                // or to request the vCard of the contact

                // Verify if the contact is already in the roster
                if (roster.Contains(ri.Jid.Local))
                {
                    continue;
                }

                roster.Add(ri.Jid.Local);
                flowLayoutPanel1.Invoke(new Action(() => Crate_ChatCard(ri.Jid.Local, "Start Chatting!")));
            }

            //add self to chat cards
            if (!roster.Contains(xmppClient.Jid.Local))
            {
                roster.Add(xmppClient.Jid.Local);
                flowLayoutPanel1.Invoke(new Action(() => Crate_ChatCard(xmppClient.Jid.Local, "Start Chatting!")));
            }

            //send probe to all contacts
            foreach (var contact in roster)
            {
                var probeiq = new XmppDotNet.Xmpp.Client.Presence
                    { Type = PresenceType.Probe, To = contact + "@alumchat.lol" };
                await xmppClient.SendPresenceAsync(probeiq);
            }

            
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
                chatCard.Click += NewCard_ChatCardClicked;
            }
            
        }

        // Manejar el evento de clic en una tarjeta de chat
        private void NewCard_ChatCardClicked(object sender, EventArgs e)
        {
            crlChatCard clickedCard = sender as crlChatCard;
            if (clickedCard != null)
            {
                //MessageBox.Show("Tarjeta de: " + clickedCard.UserName);
                //Search for the conversation
                string user = clickedCard.UserName;
                currectChat = user;
                List<List<string>> conversation;
                //Clear the chat
                flpChat.Controls.Clear();
                try
                {
                    //if no conversation is found, show toast and return
                     conversation = conversations_DM[user];
                }
                catch (Exception exception)
                {
                    //frmToasMessage toasMessage = new frmToasMessage("info", "No messages!");
                    //toasMessage.Show();
                    flpChat.Visible = true;
                    tbChatMsg.Visible = true;
                    btSendChatMsg.Visible = true;
                    btSendFile.Visible = true;
                    return;
                }
                

                //Add the messages to the chat
                foreach (var message in conversation)
                {
                    string userMessage = message[0];
                    string messageText = message[1];
                    if (userMessage == xmppClient.Jid.Local)
                    {
                        AddMessageToChat(messageText, true);
                    }
                    else
                    {
                        AddMessageToChat(messageText, false, userMessage);
                    }
                }
                tbChatMsg.Visible = true;
                btSendChatMsg.Visible = true;
                btSendFile.Visible = true;
                flpChat.Visible = true;
            }
        }

        private void AddMessageToChat(string message, bool isUser, string userName = null)
        {
            // add label to the flow layout panel
            MaterialMultiLineTextBox2 tbMessBox = new MaterialMultiLineTextBox2();
            //verify if the messages is an url
            Uri uriResult;
            bool result = Uri.TryCreate(message, UriKind.Absolute, out uriResult)
                          && uriResult.Scheme == Uri.UriSchemeHttps;
           
            if (isUser)
            {
                tbMessBox.Text = "You" + Environment.NewLine + message;
                // split the text every 50 characters and count the elements
                int lines = tbMessBox.Text.Length / 50;
                tbMessBox.ReadOnly = true;
                tbMessBox.BackColor = Color.MediumPurple;
                tbMessBox.ForeColor = Color.White;
                tbMessBox.Width = 486;
                // for each line add 20 to the height
                tbMessBox.Height = 60 + (lines * 20);
                tbMessBox.Margin = new Padding(0, 0, 0, 10);
                tbMessBox.TextAlign = HorizontalAlignment.Right;
                //flpChat.Controls.Add(tbMessBox);
                flpChat.Invoke(new Action(() => flpChat.Controls.Add(tbMessBox)));
                //scroll to the bottom
                flpChat.Invoke(new Action(() => flpChat.ScrollControlIntoView(tbMessBox)));
            }
            else
            {

                tbMessBox.Text = userName + Environment.NewLine + message;
                // split the text every 50 characters and count the elements
                int lines = tbMessBox.Text.Length / 50;
                tbMessBox.ReadOnly = true;
                tbMessBox.BackColor = Color.FromArgb(0, 0, 0);
                tbMessBox.ForeColor = Color.FromArgb(255, 255, 255);
                tbMessBox.Width = 486;
                // for each line add 20 to the height
                tbMessBox.Height = 60 + (lines * 20);
                tbMessBox.Margin = new Padding(0, 0, 0, 10);
                tbMessBox.TextAlign = HorizontalAlignment.Left;
                //flpChat.Controls.Add(tbMessBox);
                flpChat.Invoke(new Action(() => flpChat.Controls.Add(tbMessBox)));
                flpChat.Invoke(new Action(() => flpChat.ScrollControlIntoView(tbMessBox)));
            }
            
            if (result)
            {
                //add a web browser to the flow layout panel
                WebBrowser webBrowser = new WebBrowser();
                webBrowser.Navigate(message);
                webBrowser.Width = 486;
                webBrowser.Margin = new Padding(0, 0, 0, 10);

                //flpChat.Controls.Add(webBrowser);
                flpChat.Invoke(new Action(() => flpChat.Controls.Add(webBrowser)));
                flpChat.Invoke(new Action(() => flpChat.ScrollControlIntoView(webBrowser)));
                return;
            }
        }
        private async void frmChat_Load(object sender, EventArgs e)
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
                user = user.Split('@')[0];

                // Add the message to the conversation
                if (!conversations_DM.ContainsKey(user))
                {
                    conversations_DM[user] = new List<List<string>>();
                }

                conversations_DM[user].Add(new List<string> { xmppClient.Jid.Local, message });

                flowLayoutPanel1.Invoke(new Action(() => Crate_ChatCard(user, message)));
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
            currectChat = "";
            if (tcChat.SelectedTab == tabDM)
            {
            }
            else if (tcChat.SelectedTab == tabChats)
            {
                await getRooster();
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
                await getRooster();
            }
            catch (XmppException xmException)
            {
                frmToasMessage toasMessage = new frmToasMessage("error", xmException.Message);
                toasMessage.Show();
                Console.WriteLine(xmException.Stanza);
                throw;
            }
            

            
        }

        private async void btsuscribeRoom_Click(object sender, EventArgs e)
        {
            try
            {
                var RoomId = new Jid(cmbRooms.SelectedItem.ToString());

                await MucManager.EnterRoomAsync(RoomId, xmppClient.Jid.Local);

                frmToasMessage toasMessage = new frmToasMessage("success", "Room joined");
                toasMessage.Show();


            }
            catch (XmppException ex)
            {
                frmToasMessage toasMessage = new frmToasMessage("error", ex.Message);
                toasMessage.Show();
                Console.WriteLine(ex.Stanza);
                throw;
            }
        }


        private void btSendChatMsg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currectChat))
            {
                frmToasMessage toasMessage = new frmToasMessage("info", "Select a chat!");
                toasMessage.Show();
                return;
            }
            string message = tbChatMsg.Text;
            if (string.IsNullOrEmpty(message))
            {
                frmToasMessage toasMessage = new frmToasMessage("info", "Enter a message!");
                toasMessage.Show();
                return;
            }
            var user = currectChat;
            //verify if is a group chat
            if (!currectChat.Contains("@conference.alumchat.lol"))
            {
                user = currectChat + "@alumchat.lol";
                // send a chat message
                xmppClient.SendChatMessageAsync(user, message);
                AddMessageToChat(message, true);

                // Add the message to the conversation
                if (!conversations_DM.ContainsKey(currectChat))
                {
                    conversations_DM[currectChat] = new List<List<string>>();
                }

                conversations_DM[currectChat].Add(new List<string> { xmppClient.Jid.Local, message });
            }
            else
            {
                xmppClient.SendGroupChatMessageAsync(user, message);
                //AddMessageToChat(message, true);
                //No need to add the message to the chat
                //The message will be added when the message is received
            }
           
            tbChatMsg.Text = "";

           

            //update chatcard with createChatCard method
            flowLayoutPanel1.Invoke(new Action(() => Crate_ChatCard(currectChat, message)));
            


        }

        private void tbChatMsg_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tbChatMsg_KeyDown(object sender, KeyEventArgs e)
        {
            //if the user press enter send the message
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                btSendChatMsg_Click(sender, e);
            }
        }
    }
}
