

char[] text = Console.ReadLine().ToCharArray();

SortedDictionary<char,int> symbols = new SortedDictionary<char,int>();
foreach (var c in text)
{
    if (!symbols.ContainsKey(c))
    symbols.Add(c, 1);
    else symbols[c]++;
}
foreach (var c in symbols)
{
    Console.WriteLine($"{c.Key}: {c.Value} time/s");
}
