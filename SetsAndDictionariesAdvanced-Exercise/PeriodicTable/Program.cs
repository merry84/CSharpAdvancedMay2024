
int count = int.Parse(Console.ReadLine());

HashSet<string> list = new();// or sortedSet

for (int i = 0; i < count; i++)
{
    string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    foreach (string s in input)
    {
        list.Add(s);
    }
}
Console.WriteLine(string.Join(" ", list.OrderBy(x => x)));