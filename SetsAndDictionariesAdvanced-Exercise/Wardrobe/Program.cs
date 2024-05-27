

Dictionary<string, Dictionary<string, int>> wardobe = new();

int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    string[] colors = Console.ReadLine().Split(" -> ");
    string color = colors[0];

    if (!wardobe.ContainsKey(color))
    {
        wardobe.Add(color,new Dictionary<string, int>());
    }
    string[]clothes = colors[1].Split(",");

    foreach(string clothe in clothes)
    {
        if (!wardobe[color].ContainsKey(clothe))
        {
            wardobe[color].Add(clothe, 0);
        }
        wardobe[color][clothe]++;
    }
}
string[] searchClotes = Console.ReadLine().Split(" ");
string colorSearch = searchClotes[0];
string itemSearch = searchClotes[1];

foreach(var color in wardobe)
{
    Console.WriteLine($"{color.Key} clothes:");

    foreach(var item in color.Value)
    {
        if(color.Key == colorSearch &&  item.Key == itemSearch)
        {
            Console.WriteLine($" * {item.Key} - {item.Value} (found!)");
            continue;
        }
        Console.WriteLine($" * {item.Key} - {item.Value}");
    }
}
/*  Blue clothes:
               * dress - 1 (found!)
               * jeans - 1
               * hat - 1
               * gloves - 1
*/
