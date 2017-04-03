using System;
using ObserverSampleApp.News;

namespace ObserverSampleApp.Widgets
{
    class TvWidget : IObserver, IWidget
    {
        private string _tv;
        private ISubject _subject;
        public TvWidget(ISubject subject)
        {
            _subject = subject;
            _subject.RegisterObserver(this);
        }
        public void Update(string twitter, string lenta, string tv)
        {
            _tv = tv;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("TV: {0}", _tv);
        }

        public void Unsubscribe()
        {
            _subject.RemoveObserver(this);
        }
    }
}
