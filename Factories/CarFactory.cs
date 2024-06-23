using Factory_Test.Vehicles;

namespace Factory_Test.Factories
{
    class CarFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            return new Car();
        }
    }
}
