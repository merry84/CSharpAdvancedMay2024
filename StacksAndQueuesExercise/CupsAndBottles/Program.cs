

int[] cupsCapacity = Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse).ToArray();

int[] filledBottles = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse).ToArray();

int wastedLittersOfWater = 0;


Stack<int>bottles = new Stack<int>(filledBottles);
Queue<int>cups = new Queue<int>(cupsCapacity);