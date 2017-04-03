using TemplateMethodPattern.AlgorithmBase;

namespace TemplateMethodPattern
{
    public class Message
    {
        public NotificationSenderBase Sender { get; set; }

        public void Send()
        {
            Sender.Notify();
        }
    }
}
