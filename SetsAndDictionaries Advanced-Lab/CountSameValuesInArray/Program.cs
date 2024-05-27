
double[] numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(double.Parse)
    .ToArray();

Dictionary<double, int> elementsCount = new Dictionary<double, int>();

foreach (var element in numbers)
{
    if (elementsCount.ContainsKey(element))
    {
        elementsCount[element]++;
    }
    else
        elementsCount.Add(element, 1);
}
foreach (var element in elementsCount)
{
    Console.WriteLine($"{element.Key} - {element.Value} times");

}