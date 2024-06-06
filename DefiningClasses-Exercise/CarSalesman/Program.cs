using System.Collections.Generic;
using System.Diagnostics;

namespace CarSalesman
{
    public class Program
    {
/*
4
DSL-10 280 B
V7-55 200 35
DSL-13 305 55 A+
V7-54 190 30 D
4
FordMondeo DSL-13 Purple
VolkswagenPolo V7-54 1200 Yellow
VolkswagenPassat DSL-10 1375 Blue
FordFusion DSL-13
*/
        static void Main(string[] args)
        {

            List<Engine> listEngine = ReadListEngine();
            List<Car> cars = ReadCarInfo(listEngine);
            Console.WriteLine(string.Join(Environment.NewLine, cars));
           /*"{CarModel}:
              {EngineModel}:
                Power: {EnginePower}
                Displacement: {EngineDisplacement}
                Efficiency: {EngineEfficiency}
              Weight: {CarWeight}
              Color: {CarColor}"
            */
            
        }

        static List<Car> ReadCarInfo(List<Engine> engineList)
        {
            int countCar = int.Parse(Console.ReadLine());
            List<Car> carList = new();


            for (int i = 0; i < countCar; i++)
            {
                //"{model} {engine} {weight} {color}".
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                string engineModel = input[1];
                string weight;
                string color;

                Engine currentCarEngine = engineList.FirstOrDefault(x => x.Model == engineModel);
                Car car = new Car(model, currentCarEngine);

                if (input.Length == 3)
                {
                    if (char.IsDigit(input[2][0]))
                    {
                        weight = input[2];

                        car.Weight = weight;
                    }
                    else
                    {
                        color = input[2];
                        car.Color = color;
                    }
                }
                if (input.Length == 4)
                {
                    weight = input[2];
                    color = input[3];
                    car.Weight = weight;
                    car.Color = color;
                }
                carList.Add(car);
            }
            return carList;
        }
        static List<Engine> ReadListEngine()
        {
            int countEngine = int.Parse(Console.ReadLine());
            List<Engine> engines = new();

            for (int i = 0; i < countEngine; i++)
            {
                //"{model} {power} {displacement} {efficiency}"
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                int power = int.Parse(input[1]);
                string displasment;
                string efficiency;
                Engine engine = new Engine(model, power);

                if (input.Length == 3)
                {
                    if (char.IsDigit(input[2][0]))//ако започва с цифра
                    {
                        displasment = input[2];
                        engine.Displasment = displasment;
                    }
                    else
                    {
                        efficiency = input[2];
                        engine.Efficiency = efficiency;

                    }
                }
                if (input.Length == 4)
                {
                    displasment = input[2];
                    engine.Displasment = displasment;
                    efficiency = input[3];
                    engine.Efficiency = efficiency;

                }
                engines.Add(engine);
            }
            return engines;
        }

    }   
}
