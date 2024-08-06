using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XmppDotNet;
using XmppDotNet.Extensions.Client.Message;
using XmppDotNet.Extensions.Client.Presence;
using XmppDotNet.Extensions.Client.Roster;
using XmppDotNet.Transport;
using XmppDotNet.Transport.Socket;
using XmppDotNet.Xmpp.Avatar;
using XmppDotNet.Xmpp.Register;

namespace Proyecto1_Redes.Forms
{
    public class RegisterAccountHandler : IRegister
    {
        private XmppClient xmppClient;
        public RegisterAccountHandler(XmppClient xmppClient)
        {
            this.xmppClient = xmppClient;
        }

        public bool RegisterNewAccount => true;

        public async Task<Register> RegisterAsync(Register register)
        {
            return await Task<Register>.Run(() =>
            {
                register.XData.Remove();
                register.RemoveAll<Data>();
                register.Username = xmppClient.Jid.Local;
                register.Password = xmppClient.Password;

                return register;
            });
        }
    }
}
