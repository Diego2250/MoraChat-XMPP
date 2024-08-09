﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

namespace Proyecto1_Redes.Forms
{
    public partial class MoraChat : MaterialSkin.Controls.MaterialForm
    {
        private List<string> roster = new List<string>();
        public XmppClient xmppClient;
        public MoraChat(XmppClient xmppClient)
        {
            this.xmppClient = xmppClient;
            //xmppClient.XmppXElementReceived.Subscribe(x =>
            //{
            //    //MessageBox.Show(x.ToString());
            //    // If is a new contact, add it to the roster
            //    if (x.Name.LocalName == "iq")
            //    {
            //        var iq = x.Cast<Iq>();
            //        if (iq.Type == IqType.Set)
            //        {
            //            // Verify if the ask is unsubscribe or subscribe
            //            var query = iq.Query.Cast<Roster>();
            //            var item = query.GetRoster().First();
            //            if (item.Ask == Ask.Unsubscribe)
            //            {
            //                // Remove the contact from the roster where the jid is the same
            //                roster.RemoveAll(r => r == item.Jid);

            //            }
            //            else if (item.Ask == Ask.Subscribe)
            //            {
            //                roster.Add(item.Jid);
            //            }

            //            // print roster items in console
            //            foreach (var ri in roster)
            //            {
            //                Console.WriteLine($"Jid: {ri}");
            //            }
            //        }
            //    }
            //});


            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple900, Primary.Purple900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        

        private async void frmChat_Load(object sender, EventArgs e)
        {
            // request the roster from the server
            var rosterIqResult = await xmppClient.RequestRosterAsync();

            // get all rosterItems (list of contacts)
            var rosterItems
                = rosterIqResult
                    .Query
                    .Cast<Roster>()
                    .GetRoster();

            // enumerate over the items and build your contact list or GUI
            foreach (var ri in rosterItems)
            {
                
                // Save the Jids
                // You can use this to send messages to the contact
                // or to request the vCard of the contact
                roster.Add(ri.Jid);

                // Dump some info
                Console.WriteLine($"Jid: {ri.Jid}");
                Console.WriteLine($"Name: {ri.Name}");
            }
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

        private void Label1_Click(object sender, EventArgs e)
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
                // construct the iq query
                var vcardRequest = new VcardIq { Type = IqType.Get, To = xmppClient.Jid };

                // send the request and await the response
                var resultIq = await xmppClient.SendIqAsync(vcardRequest);

                
                // check for success or failure
                if (resultIq.Type == IqType.Result)
                {
                    // server returned a result (sucsess)
                    // => process the vCard here
                }
                else if (resultIq.Type == IqType.Error)
                {
                    // server returned an error
                    // => handle error
                }

            }
        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}