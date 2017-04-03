using System;
using ObserverSampleApp.News;
using ObserverSampleApp.Widgets;

namespace ObserverSampleApp
{
    class Program
    {
        static void Main()
        {
            var newsAggregator = new NewsAggregator();

            var twitterWidget = new TwitterWidget(newsAggregator);
            var lentaWidget = new LentaWidget(newsAggregator);
            var tvWidget = new TvWidget(newsAggregator);

            newsAggregator.NewNewsAvailable();

            Console.WriteLine();

            twitterWidget.Unsubscribe();

            newsAggregator.NewNewsAvailable();
        }
    }
}
