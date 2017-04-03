using System;
using ObserverSampleApp.News;

namespace ObserverSampleApp.Widgets
{
    class LentaWidget : IObserver, IWidget
    {
        private string _lenta;
        private ISubject _subject;
        public LentaWidget(ISubject subject)
        {
            _subject = subject;
            _subject.RegisterObserver(this);
        }
        public void Update(string twitter, string lenta, string tv)
        {
            _lenta = lenta;
            Display();
        }

        public void Unsubscribe()
        {
            _subject.RemoveObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Lenta: {0}", _lenta);
        }
    }
}
