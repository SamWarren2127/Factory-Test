using Factory_Test.Vehicles;
using Factory_Test.Factories;
using Factory_Test.Utilities;

namespace Factory_Test
{
    class Program
    {
        private static Logger logger = new Logger();

        static void Main(string[] args)
        {
            try
            {
                logger.WriteLine("======================= Factory Test App =======================");
                
                if (args.Length == 0)
                {
                    CreateAllVehicles();
                }
                else
                {
                    var vehicleName = args[0];

                    if (vehicleName == string.Empty)
                    {
                        throw new ArgumentException(message: "Parameter cannot be empty", paramName: "Vehicle Name");
                    }

                    CreateSpecificVehicle(vehicleName);
                }

                logger.WriteLine("=========================== Finished ===========================");
            }
            catch (Exception ex)
            {
                logger.WriteLine($"{(ex.InnerException == null ? ex.Message : ex.InnerException.Message)}");
            }
        }

        public static void CreateAllVehicles()
        {
            logger.WriteLine("Creating 4 different types of vehicles through factories");
            logger.WriteLine("Vehicles:");

            var car = CreateCar();
            logger.WriteLine(car.GetType());

            var bike = CreateBike();
            logger.WriteLine(bike.GetType());

            var boat = CreateBoat();
            logger.WriteLine(boat.GetType());

            var plane = CreatePlane();
            logger.WriteLine(plane.GetType());
        }

        public static void CreateSpecificVehicle(string vehicleName)
        {
            logger.WriteLine("Creating a specific vehicle.");

            switch (vehicleName)
            {
                case "Car":
                    var car = CreateCar();
                    logger.WriteLine(car.GetType());
                    break;

                case "Bike":
                    var bike = CreateBike();
                    logger.WriteLine(bike.GetType());
                    break;

                case "Boat":
                    var boat = CreateBoat();
                    logger.WriteLine(boat.GetType());
                    break;

                case "Plane":
                    var plane = CreatePlane();
                    logger.WriteLine(plane.GetType());
                    break;

                default:
                    logger.WriteLine($"Couldnt find vehicle - {vehicleName}");
                    break;
            }
        }

        private static IVehicle CreateCar()
        {
            var carFactory = new CarFactory();
            return carFactory.CreateVehicle();
        }

        private static IVehicle CreateBike()
        {
            var bikeFactory = new BikeFactory();
            return bikeFactory.CreateVehicle();
        }

        private static IVehicle CreatePlane()
        {
            var planeFactory = new PlaneFactory();
            return planeFactory.CreateVehicle();
        }

        private static IVehicle CreateBoat()
        {
            var boatFactory = new BoatFactory();
            return boatFactory.CreateVehicle();
        }
    }
}