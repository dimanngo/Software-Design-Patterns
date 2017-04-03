using System;
using ObserverSampleApp.Widgets;
using ObserverSampleApp_Events.News;

namespace ObserverSampleApp_Events.Widgets
{
    class LentaWidget : IWidget
    {
        private string _lenta;
        public void Update(object sender, NewsEventArgs e)
        {
            _lenta = e.Lenta;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Lenta: {0}", _lenta);
        }
    }
}
