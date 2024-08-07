using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XmppDotNet.Xmpp.MessageArchiveManagement;
using XmppDotNet.Xmpp;
using XmppDotNet.Xmpp.Base;

namespace Proyecto1_Redes.Classes
{
    public class MamResult
    {
        // was this request a Success or failure
        public bool IsSuccess { get; set; }
        // is the result complete, or can we request more pages
        public bool Complete { get; set; }
        // last is in the results for paging
        public string Last { get; set; }
        // first is in teh results for paging
        public string First { get; set; }

        // collection of messages retrieved
        public ReadOnlyCollection<Message> Messages { get; set; }

        public MamResult WithMessages(List<Message> messages)
        {
            Messages = new ReadOnlyCollection<Message>(messages);
            return this;
        }

        public static MamResult FromIq(Iq iq)
        {
            if (iq.Type == IqType.Result)
            {
                // success
                if (iq.Query is Final final)
                {
                    return new MamResult()
                    {
                        IsSuccess = true,
                        Complete = final.Complete,
                        Last = final.ResultSet.Last,
                        First = final.ResultSet.First.Value
                    };
                }
            }

            return new MamResult()
            {
                IsSuccess = false,
            };
        }
    }
}
