namespace WarmWinter
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //take the last given hat, and the first given scarf 
            Stack<int> hats = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            Queue<int> scarfs = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            List<int> sets = new List<int>();
            while (hats.Any() && scarfs.Any())
            {
                int hat = hats.Peek();
                int scarf = scarfs.Peek();
                if (hat > scarf)
                {
                    sets.Add(hat + scarf);
                    hats.Pop();
                    scarfs.Dequeue();
                }
                else if (hat < scarf)
                {
                    hats.Pop();
                }
                else if (hat == scarf)
                {
                    scarfs.Dequeue();
                    hats.Pop();
                    hats.Push(hat + 1);
                }
            }
            Console.WriteLine($"The most expensive set is: {sets.Max()}");
            Console.WriteLine($"{string.Join(" ", sets)}");
            //:  "The most expensive set is: {maxPriceSet}"
        }
    }
}
