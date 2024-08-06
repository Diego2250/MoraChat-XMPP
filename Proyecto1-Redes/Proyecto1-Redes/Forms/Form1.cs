﻿using MaterialSkin;
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

            string username = tbUser.Text + "@alumchat.lol";
            string password = tbPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Enter a username and password");
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
                    conf.AutoReconnect = true;
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
                MessageBox.Show("Account created successfully!");

            }
            catch (XmppDotNet.RegisterException e)
            {
                MessageBox.Show($"Error while creating account: {e.Message}");
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

            try
            {
                await xmppClient.ConnectAsync();
                MessageBox.Show("Connection Successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while connecting: {ex.Message}");
            }

            return;
        }


    }
}