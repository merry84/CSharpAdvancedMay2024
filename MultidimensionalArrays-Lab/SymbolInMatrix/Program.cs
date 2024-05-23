

int size = int.Parse(Console.ReadLine());
int rows = size;
int cols = size;
int[,] matrix = new int[rows, cols];

//пълним матрицата
for (int i = 0; i < rows; i++)
{
    char[] elements = Console.ReadLine()
    .ToCharArray();
    for (int j = 0; j < cols; j++)
    {
        matrix[i, j] = elements[j];
    }
}
char symbol = char.Parse(Console.ReadLine());

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] == symbol)
        {
            Console.WriteLine($"({i}, {j})");
            return;
        }
    }
}
Console.WriteLine($"{symbol} does not occur in the matrix");