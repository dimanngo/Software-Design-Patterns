using BridgePattern.ConcreteImplementations;
using BridgePattern.Implementor;

namespace BridgePattern.Abstraction
{
    public class Message
    {
        protected MessageSenderBase messageSender { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int Importance { get; set; }


        public Message()
        {
            messageSender = new EmailSender();
        }

        public virtual void Send()
        {
            messageSender.SendMessage(Title, Body, Importance);
        }
    }
}