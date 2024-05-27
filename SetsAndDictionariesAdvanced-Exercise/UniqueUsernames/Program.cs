
int count = int.Parse(Console.ReadLine());

HashSet<string> list = new();

for (int i = 0; i < count; i++)
{
    string input = Console.ReadLine();
    list.Add(input);
}


foreach (string name in list)
{
    Console.WriteLine(name);
}