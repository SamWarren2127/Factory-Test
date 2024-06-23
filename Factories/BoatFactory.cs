using Factory_Test.Vehicles;

namespace Factory_Test.Factories;

class BoatFactory : VehicleFactory
{
    public override IVehicle CreateVehicle()
    {
        return new Boat();
    }
}
