using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObserverPattern.ConcreteSubject;
using ObserverPattern.ObserverBase;

namespace ObserverPattern.ConcreteObservers
{
    public class AllStockObserver : IStockObserverBase
    {
        public AllStockObserver(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void Notify(Stock stock)
        {
            Console.WriteLine("Notified {0} of {1}'s " +
                              "change to {2:C}", Name, stock.Code, stock.Price);
        }
    }

    
}
