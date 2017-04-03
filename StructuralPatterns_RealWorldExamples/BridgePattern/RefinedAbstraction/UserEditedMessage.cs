using BridgePattern.Abstraction;
using BridgePattern.Implementor;

namespace BridgePattern.RefinedAbstraction
{
    public class UserEditedMessage : Message
    {
        public string UserComments { get; set; }
        
        public UserEditedMessage(MessageSenderBase messageSender)
        {
            this.messageSender = messageSender;
        }

        public override void Send()
        {
            string fullBody = string.Format("{0}\nCOMMENTS\n{1}", Body, UserComments);
            messageSender.SendMessage(Title, fullBody, Importance);
        }
    }
}