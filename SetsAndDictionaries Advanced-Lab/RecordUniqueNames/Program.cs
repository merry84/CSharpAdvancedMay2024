

int count = int.Parse(Console.ReadLine());

HashSet<string> list = new();

for (int i = 0; i < count; i++)
{
    string names = Console.ReadLine();
    list.Add(names);
}

foreach (string name in list)
{
    Console.WriteLine(name);
}