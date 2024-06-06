namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int countCar = int.Parse(Console.ReadLine());

            List<Car> cars = new ();
            for (int i = 0; i < countCar; i++) 
            {
                //"{model} {engineSpeed} {enginePower} {cargoWeight} {cargoType} {tire1Pressure} {tire1Age} {tire2Pressure} {tire2Age} {tire2Pressure} {tire3Pressure} {tire3Age} {tire4Pressure} {tire4Age}"
                string[] infoCar = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string model = infoCar[0];
                int engineSpeed = int.Parse(infoCar[1]);
                int enginePower = int.Parse(infoCar[2]);
                int cargoWeight = int.Parse(infoCar[3]);
                string cargoType = infoCar[4];
                
                double tire1Pressure = double.Parse(infoCar[5]);
                int tire1Age = int.Parse(infoCar[6]);
                double tire2Pressure = double.Parse(infoCar[7]);
                int tire2Age = int.Parse(infoCar[8]);
                double tire3Pressure = double.Parse(infoCar[9]);
                int tire3Age = int.Parse(infoCar[10]);
                double tire4Pressure = double.Parse(infoCar[11]);
                int tire4Age = int.Parse(infoCar[12]);

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoType, cargoWeight);
                Tires[] tires = new Tires[]
                {
                    new Tires(tire1Pressure,tire1Age),
                    new Tires(tire2Pressure,tire2Age),
                    new Tires(tire3Pressure,tire3Age),
                    new Tires(tire4Pressure,tire4Age),
                };

                Car car = new Car(model,engine,cargo,tires);
                cars.Add(car);
            }

            //Next, you will receive a single line with one of the following commands:  "fragile" or "flammable".
            string command = Console.ReadLine();
            /*•	"fragile" - print all cars, whose cargo is "fragile" and have a pressure of a single tire < 1.
            •	"flammable" - print all cars, whose cargo is "flammable" and have engine power > 250.
            */
            if (command == "fragile")
            {
                cars = cars.Where(x => x.Tires.Any(c => c.Pressure < 1)).ToList();
            }
            else if(command == "flammable")
            {
                cars= cars.Where(x=>x.Engine.Power >250).ToList();
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}
