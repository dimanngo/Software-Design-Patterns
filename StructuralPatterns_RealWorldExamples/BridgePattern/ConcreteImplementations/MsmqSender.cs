using System;
using BridgePattern.Implementor;

namespace BridgePattern.ConcreteImplementations
{
    public class MsmqSender : MessageSenderBase
    {
        public override void SendMessage(string title, string body, int importance)
        {
            Console.WriteLine("MSMQ\n{0}\n{1}\n{2}\n", title, body, importance);
        }
    }
}