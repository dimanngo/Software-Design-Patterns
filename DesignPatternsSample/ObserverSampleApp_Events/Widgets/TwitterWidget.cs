using System;
using ObserverSampleApp.Widgets;
using ObserverSampleApp_Events.News;

namespace ObserverSampleApp_Events.Widgets
{
    class TwitterWidget : IWidget
    {
        private string _twitter;
        public void Update(object sender, NewsEventArgs e)
        {
            _twitter = e.Twitter;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Twitter: {0}", _twitter);
        }
    }
}
