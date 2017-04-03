using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObserverPattern.ConcreteSubject;

namespace ObserverPattern.ObserverBase
{
    public interface IStockObserverBase
    {
        void Notify(Stock stock);
    }
}
