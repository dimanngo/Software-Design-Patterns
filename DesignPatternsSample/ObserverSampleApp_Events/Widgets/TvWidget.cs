using System;
using ObserverSampleApp.Widgets;
using ObserverSampleApp_Events.News;

namespace ObserverSampleApp_Events.Widgets
{
    class TvWidget : IWidget
    {
        private string _tv;
        public void Update(object sender, NewsEventArgs e)
        {
            _tv = e.Tv;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("TV: {0}", _tv);
        }
    }
}
