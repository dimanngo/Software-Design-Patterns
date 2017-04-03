using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethodPattern.AlgorithmBase
{
    public abstract class NotificationSenderBase
    {
        protected SystemOperator _operator;

        public NotificationSenderBase(SystemOperator systemOperator)
        {
            _operator = systemOperator;
        }

        protected abstract string GetNotificationMessageText();
        

        public abstract void Notify();

    }
}
