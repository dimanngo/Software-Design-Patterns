using System;
using TemplateMethodPattern.AlgorithmBase;

namespace TemplateMethodPattern
{
    public class MailNotificationSender : NotificationSenderBase
    {
        public MailNotificationSender(SystemOperator systemOperator) : base(systemOperator)
        {
        }

        protected override string GetNotificationMessageText()
        {
            return "[UNSPECIFIED ERROR OCCURED]";
        }

        public override void Notify()
        {
            Console.WriteLine("EMAIL MESSAGE:{0} WAS SET TO: {1}", GetNotificationMessageText(), _operator.Email);
        }
    }
}
