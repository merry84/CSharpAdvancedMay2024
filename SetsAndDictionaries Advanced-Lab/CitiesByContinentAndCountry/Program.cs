using System;
using System.Collections.Generic;

int count = int.Parse(Console.ReadLine());

Dictionary<string, Dictionary<string, List<string>>> inputInfo = new();

for (int i = 0; i < count; i++)
{
    string[] elements = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string continent = elements[0];
    string country = elements[1];
    string city = elements[2];
    if (!inputInfo.ContainsKey(continent))
    {
        inputInfo.Add(continent, new Dictionary<string, List<string>>());
    }
    if (!inputInfo[continent].ContainsKey(country))
    {
        inputInfo[continent].Add(country, new List<string>());
    }
    inputInfo[continent][country].Add(city);
}
/*Europe:
  Bulgaria -> Sofia, Plovdiv
  Poland -> Warsaw, Poznan
  Germany -> Berlin
Asia:
  China -> Beijing, Shanghai
  Japan -> Tokyo
Africa:
  Nigeria -> Abuja
*/
foreach (var item in inputInfo)
{
    Console.WriteLine($"{item.Key}:");
    foreach (var item2 in item.Value)
    {
        Console.WriteLine($"  {item2.Key} -> {string.Join(", ", item2.Value)} ");
    }
}