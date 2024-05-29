namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuatity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());

            Car car1 = new Car();
            Car car2 = new Car(make, model, year);
            Car car = new Car(make, model, year, fuelQuatity, fuelConsumption);
        }
    }
}


