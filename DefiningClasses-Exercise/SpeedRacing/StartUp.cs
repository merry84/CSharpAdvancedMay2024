using System.Reflection;

namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int countCar = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < countCar; i++)
            {
                //"{model} {fuelAmount} {fuelConsumptionFor1km}"
                string[] carInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumptionFor1km = double.Parse(carInfo[2]);
                //All cars start at 0 kilometers traveled. 
                Car car = new Car(model, fuelAmount, fuelConsumptionFor1km, 0);
                cars.Add(car);
            }
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                //"Drive {carModel} {amountOfKm}"

                string[] action = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string carModel = action[1];
                double amountOfKm = double.Parse(action[2]);

                Car car = cars
                    .Where(x => x.Model == carModel)
                    .FirstOrDefault();
                car.DriveCar(amountOfKm);
            }
            // "{model} {fuelAmount} {distanceTraveled}"
            //Print the fuel amount formatted two digits after the decimal separator.
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.Distance}");
            }

        }
    }
}
