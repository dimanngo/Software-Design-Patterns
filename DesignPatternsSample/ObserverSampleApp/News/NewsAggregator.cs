using System;
using System.Collections.Generic;
using ObserverSampleApp.Widgets;

namespace ObserverSampleApp.News
{
    public class NewsAggregator : ISubject
    {
        private readonly Random _random;
        private readonly List<IObserver> _observers;

        public NewsAggregator()
        {
            _random = new Random();
            _observers = new List<IObserver>();
        }

        public string GetTwitterNews()
        {
            var news = new List<string>
                {
                    "News from Twitter #1",
                    "News from Twitter #2",
                    "News from Twitter #3"
                };

            return news[_random.Next(news.Count)];
        }

        public string GetLentaNews()
        {
            var news = new List<string>
                {
                    "News from Lenta #1",
                    "News from Lenta #2",
                    "News from Lenta #3"
                };

            return news[_random.Next(news.Count)];
        }

        public string GetTvNews()
        {
            var news = new List<string>
                {
                    "News from TV #1",
                    "News from TV #2",
                    "News from TV #3"
                };

            return news[_random.Next(news.Count)];
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            string twitter = GetTwitterNews();
            string lenta = GetLentaNews();
            string tv = GetTvNews();

            foreach (var observer in _observers)
            {
                observer.Update(twitter, lenta, tv);
            }
        }

        public void NewNewsAvailable()
        {
            NotifyObservers();
        }
    }
}