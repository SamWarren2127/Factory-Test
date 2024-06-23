using Factory_Test.Vehicles;

namespace Factory_Test.Factories
{
    abstract class VehicleFactory
    {
        public abstract IVehicle CreateVehicle();
    }
}
