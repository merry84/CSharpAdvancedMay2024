
string[] size = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

int rows = int.Parse(size[0]);
int cols = int.Parse(size[1]);
int[,] matrix = new int[rows, cols];

for (int i = 0; i < rows; i++)
{
    string[] numbers = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
    for (int j = 0; j < cols; j++)
    {
        matrix[i, j] = int.Parse(numbers[j]);
    }
}
Console.WriteLine(matrix.GetLength(0));
Console.WriteLine(matrix.GetLength(1));
int sumMatrix = 0;
foreach (int number in matrix)
{
    sumMatrix += number;
}
Console.WriteLine(sumMatrix);
/*7, 1, 3, 3, 2, 1
1, 3, 9, 8, 5, 6
4, 6, 7, 9, 1, 0
*/