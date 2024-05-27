
int count = int.Parse(Console.ReadLine());

Dictionary<int, int> numbers = new();

for (int i = 0; i < count; i++)
{
    int number = int.Parse(Console.ReadLine());
    if (!numbers.ContainsKey(number))
    {
        numbers.Add(number, 0);
    }
    numbers[number]++;
}

int result = numbers.Single(x => x.Value % 2 == 0).Key;
Console.WriteLine(result);
//or
//foreach(var number in numbers)
//{
//    if(number.Value % 2 == 0)
//    {
//        Console.WriteLine(number.Key);
//    }
//}