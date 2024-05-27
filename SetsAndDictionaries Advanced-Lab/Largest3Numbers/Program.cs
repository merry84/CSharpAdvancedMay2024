
List<int> numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .OrderByDescending(x => x)
    .Take(3)// for цикъл до 3
    .ToList();


//  Console.Write(string.Join(" ",numbers));

Console.WriteLine();

foreach (var number in numbers)
{
    Console.Write(number + " ");
}