using ObserverPattern.SubjectBase;

namespace ObserverPattern.ConcreteSubject
{
    public class ConcreteStockTicker:StockTickerBase
    {
        private Stock stock;
        public Stock Stock
        {
            get { return stock; }
            set { 
                stock = value;
                Notify(); 
            }
        }

        public override void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Notify(stock);
            }
        }
    }
}
