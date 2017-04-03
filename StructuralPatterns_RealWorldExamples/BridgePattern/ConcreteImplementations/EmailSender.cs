using System;
using BridgePattern.Implementor;

namespace BridgePattern.ConcreteImplementations
{
    public class EmailSender : MessageSenderBase
    {
        public override void SendMessage(string title, string body, int importance)
        {
            Console.WriteLine("Email\n{0}\n{1}\n{2}\n", title, body, importance);
        }
    }
}