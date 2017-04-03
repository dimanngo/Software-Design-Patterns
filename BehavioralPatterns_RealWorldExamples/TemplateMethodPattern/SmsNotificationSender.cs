using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TemplateMethodPattern.AlgorithmBase;

namespace TemplateMethodPattern
{
    public class SmsNotificationSender: NotificationSenderBase
    {
        public SmsNotificationSender(SystemOperator systemOperator) : base(systemOperator)
        {
        }

        protected override string GetNotificationMessageText()
        {
            return "UNSPECIFIED ERROR OCCURED";
        }

        public override void Notify()
        {
            Console.WriteLine("SMS MESSAGE:{0} WAS SET TO: {1}",GetNotificationMessageText(),_operator.CellPhone);
        }
    }
}
