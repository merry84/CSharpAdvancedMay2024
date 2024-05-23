var numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

Queue<int> evenNumbers =new();

    foreach (var number in numbers)
        if(number %2 == 0)
        {
            evenNumbers.Enqueue(number);
        }

Console.WriteLine(string.Join(", ", evenNumbers));