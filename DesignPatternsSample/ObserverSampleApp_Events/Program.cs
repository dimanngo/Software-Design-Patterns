using System;
using ObserverSampleApp_Events.News;
using ObserverSampleApp_Events.Widgets;

namespace ObserverSampleApp_Events
{
    class Program
    {
        static void Main()
        {
            var newsAggregator = new NewsAggregator();

            var twitterWidget = new TwitterWidget();
            var lentaWidget = new LentaWidget();
            var tvWidget = new TvWidget();

            newsAggregator.NewsChanged += twitterWidget.Update;
            newsAggregator.NewsChanged += lentaWidget.Update;
            newsAggregator.NewsChanged +=  tvWidget.Update;

            newsAggregator.NewNewsAvailable();
            Console.WriteLine();

            newsAggregator.NewsChanged -= lentaWidget.Update;
            newsAggregator.NewNewsAvailable();

            Console.WriteLine();
        }
    }
}
