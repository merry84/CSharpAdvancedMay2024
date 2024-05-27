
HashSet<string> vip = new();
HashSet<string> regular = new();

string input;
while ((input = Console.ReadLine()) != "PARTY")
{
    if (char.IsDigit(input[0]))
    {
        vip.Add(input);
    }
    else
    {
        regular.Add(input);
    }
}

while ((input = Console.ReadLine()) != "END")
{
    if (char.IsDigit(input[0]))
    {
        vip.Remove(input);
    }
    else
    {
        regular.Remove(input);
    }
}

Console.WriteLine(vip.Count + regular.Count);

foreach (string guest in vip)
{ Console.WriteLine(guest); }

foreach (string guest in regular)
{
    Console.WriteLine(guest);
}