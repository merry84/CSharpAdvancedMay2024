
int[] numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();


int firstLenght = numbers[0];
int secondLenght = numbers[1];
HashSet<int> firstSet = new();
HashSet<int> secondSet = new();
for (int i = 0; i < firstLenght; i++)
{
    firstSet.Add(int.Parse(Console.ReadLine()));
}

for (int i = 0; i < secondLenght; i++)
{
    secondSet.Add(int.Parse(Console.ReadLine()));
}
// метод от библиотеката HashSet, който избира общите елементи от два сета
// (в случая по реда, в който се появяват в първия сет)
// други методи от библиотеката HashSet - връщат като резултат сет
// first.UnionWith(second);  => обединява елементите от двата сета
// first.ExceptWith(second); => вземи елементите, които са уникални за първия сет и не се припокриват с втория
// first.SymmetricExceptWith(second); => Обратно на IntersectWith
firstSet.IntersectWith(secondSet);
Console.WriteLine(string.Join(" ", firstSet));
// или
//Console.WriteLine(string.Join(" ", firstSet.Intersect(secondSet)));