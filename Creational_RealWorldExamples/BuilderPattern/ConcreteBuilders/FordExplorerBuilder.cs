using BuilderPattern.Builder;

namespace BuilderPattern.ConcreteBuilders
{
    class FordExplorerBuilder : VehicleBuilder
    {
        public override void SetModel()
        {
            _vehicle.Model = "Ford Explorer";
        }

        public override void SetEngine()
        {
            _vehicle.Engine = "4.0 L Cologne V6";
        }

        public override void SetTransmission()
        {
            _vehicle.Transmission = "5-speed M5OD-R1 manual";
        }

        public override void SetBody()
        {
            _vehicle.Body = "SUV";
        }

        public override void SetDoors()
        {
            _vehicle.Doors = 5;
        }

        public override void SetAccessories()
        {
            _vehicle.Accessories.Add("Car Cover");
            _vehicle.Accessories.Add("Sun Shade");
        }
    }
}