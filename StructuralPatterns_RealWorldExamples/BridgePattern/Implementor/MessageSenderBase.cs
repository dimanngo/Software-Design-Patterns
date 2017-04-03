namespace BridgePattern.Implementor
{
    public abstract class MessageSenderBase
    {
        public abstract void SendMessage(string title, string details, int importance);
    }
}