using System;
using System.Collections.Generic;

namespace ObserverSampleApp_Events.News
{
    public class NewsEventArgs
    {
        public NewsEventArgs(string twitter, string lenta, string tv)
        {
            Twitter = twitter;
            Lenta = lenta;
            Tv = tv;
        }
        public string Twitter { get; private set; }
        public string Lenta { get; private set; }
        public string Tv { get; private set; }
    }

    public delegate void NewsChangedEventHandler(object sender, NewsEventArgs e);
    class NewsAggregator
    {
        private readonly Random _random;
        public event NewsChangedEventHandler NewsChanged;

        public NewsAggregator()
        {
            _random = new Random();
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

        public void NewNewsAvailable()
        {
            string twitter = GetTwitterNews();
            string lenta = GetLentaNews();
            string tv = GetTvNews();

            if (NewsChanged !=null)
            {
                NewsChanged(this, new NewsEventArgs(twitter, lenta, tv));
            }
        }
    }
}
