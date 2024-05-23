


int[] size = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = size[0];
int cols = size[1];
int[,] matrix = new int[rows, cols];

//пълним матрицата
for (int i = 0; i < rows; i++)
{
    int[] numbers = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray(); ;
    for (int j = 0; j < cols; j++)
    {
        matrix[i, j] = numbers[j];
    }
}

int maxRowSum = 0;
int maxColSum = 0;
int maxMatrixSum = 0;
for (int i = 0; i < matrix.GetLength(0) - 1; i++)// за да не излезнем от матрицата
{
    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
    {
        // kвадратна матрица от 2 реда и 2 колони
        int squereSum = matrix[i, j] +
            matrix[i + 1, j] +
            matrix[i, j + 1] +
            matrix[i + 1, j + 1];
        if (squereSum > maxMatrixSum)
        {
            maxMatrixSum = squereSum;
            maxColSum = j;
            maxRowSum = i;
        }
    }
}
Console.WriteLine($"{matrix[maxRowSum, maxColSum]} {matrix[maxRowSum, maxColSum + 1]}");//1 red
Console.WriteLine($"{matrix[maxRowSum + 1, maxColSum]} {matrix[maxRowSum + 1, maxColSum + 1]}");//2 red
Console.WriteLine(maxMatrixSum);
