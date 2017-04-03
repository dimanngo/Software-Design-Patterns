namespace ObserverSampleApp.Widgets
{
    public interface IObserver
    {
        void Update(string twitter, string lenta, string tv);
        void Unsubscribe();
    }
}
