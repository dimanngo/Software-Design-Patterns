using BuilderPattern.Product;

namespace BuilderPattern.Builder
{
    public abstract class VehicleBuilder
    {
        protected Vehicle _vehicle;

        public Vehicle GetVehicle()
        {
            return _vehicle;
        }

        public void CreateVehicle()
        {
            _vehicle = new Vehicle();
        }

        public abstract void SetModel();
        public abstract void SetEngine();
        public abstract void SetTransmission();
        public abstract void SetBody();
        public abstract void SetDoors();
        public abstract void SetAccessories();
    }
}
