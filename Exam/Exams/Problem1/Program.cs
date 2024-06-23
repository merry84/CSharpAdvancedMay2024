namespace Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> packages = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> couriers = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

           
            int total_weight = 0;
            while (packages.Count!=0 && couriers.Count!=0)
            {
                int package = packages.Peek();
                int courier = couriers.Dequeue();
                if (courier >= package)
                {
                    total_weight += package;
                    packages.Pop();
                    courier -=  2*package;
                    if(courier > 0)
                    {
                        couriers.Enqueue(courier);
                    }
                }
                else
                {
                    total_weight += courier;
                    package-= courier;
                    packages.Pop();
                    packages.Push(package);
                }
            }
            /*	At the end of the program, print the weight of the packages delivered:
o	"Total weight: {total_weight} kg"
	If all of the packages are delivered and there are no couriers left:
o	"Congratulations, all packages were delivered successfully by the couriers today."
	If there are packages left but no more couriers available:
o	"Unfortunately, there are no more available couriers to deliver the following packages: {package1}, {package2}, (…),{packagen}"
	If there are couriers left but there are no more packages to deliver:
o	"Couriers are still on duty: {couriers1}, {couriers2}, (…),{couriersn} but there are no more packages to deliver."
    */
            Console.WriteLine($"Total weight: {total_weight} kg");
            if (packages.Count == 0 && couriers.Count == 0)
            {
                Console.WriteLine($"Congratulations, all packages were delivered successfully by the couriers today.");
            }
            else if(packages.Count != 0 && couriers.Count ==0)
                {
                Console.WriteLine($"Unfortunately, there are no more available couriers to deliver the following packages: {string.Join(", ",packages)}");
            }
            else if(couriers.Count != 0 && packages.Count == 0)
            {
                Console.WriteLine($"Couriers are still on duty: {string.Join(", ",couriers)} but there are no more packages to deliver.");
            }
        }
    }
}
