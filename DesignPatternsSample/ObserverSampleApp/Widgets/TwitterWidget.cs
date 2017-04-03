using System;
using ObserverSampleApp.News;

namespace ObserverSampleApp.Widgets
{
    class TwitterWidget : IObserver, IWidget
    {
        private string _twitter;
        private ISubject _subject;
        public TwitterWidget(ISubject subject)
        {
            _subject = subject;
            _subject.RegisterObserver(this);
        }
        public void Update(string twitter, string lenta, string tv)
        {
            _twitter = twitter;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Twitter: {0}", _twitter);
        }

        public void Unsubscribe()
        {
            _subject.RemoveObserver(this);
        }
    }
}
