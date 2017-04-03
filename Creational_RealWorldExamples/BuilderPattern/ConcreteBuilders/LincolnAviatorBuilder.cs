using BuilderPattern.Builder;

namespace BuilderPattern.ConcreteBuilders
{
    class LincolnAviatorBuilder : VehicleBuilder
    {
        public override void SetModel()
        {
            _vehicle.Model = "Lincoln Aviator";
        }

        public override void SetEngine()
        {
            _vehicle.Engine = "4.6 L DOHC Modular V8";
        }

        public override void SetTransmission()
        {
            _vehicle.Transmission = "5-speed automatic";
        }

        public override void SetBody()
        {
            _vehicle.Body = "SUV";
        }

        public override void SetDoors()
        {
            _vehicle.Doors = 4;
        }

        public override void SetAccessories()
        {
            _vehicle.Accessories.Add("Leather Look Seat Covers");
            _vehicle.Accessories.Add("Chequered Plate Racing Floor");
            _vehicle.Accessories.Add("4x 200 Watt Coaxial Speekers");
            _vehicle.Accessories.Add("500 Watt Bass Subwoofer");
        }
    }
}