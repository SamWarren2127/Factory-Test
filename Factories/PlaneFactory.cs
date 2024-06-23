using Factory_Test.Vehicles;

namespace Factory_Test.Factories
{
    class PlaneFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            return new Plane();
        }
    }
}
