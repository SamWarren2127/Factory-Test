using Factory_Test.Vehicles;

namespace Factory_Test.Factories
{
    class BikeFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            return new Bike();
        }
    }
}
