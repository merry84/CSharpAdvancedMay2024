




int[] size = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = size[0];
int cols = size[1];
int[,] matrix = new int[rows, cols];

//пълним матрицата
for (int i = 0; i < rows; i++)
{
    int[] numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray(); ;
    for (int j = 0; j < cols; j++)
    {
        matrix[i, j] = numbers[j];
    }
}

int maxRow = 0;
int maxCol = 0;
int maxMatrixSum = 0;
for (int row = 0; row < matrix.GetLength(0) - 2; row++)// за да не излезнем от матрицата
{
    for (int col = 0; col < matrix.GetLength(1) - 2; col++)
    {
        int squereSum = 0;
        for (int k = 0; k < 3; k++)// matrix 3x3 in matix
        {
            for (int l = 0; l < 3; l++)
            {
                squereSum += matrix[row + k, col + l];
            }
        }
        if (squereSum > maxMatrixSum)
        {
            maxMatrixSum = squereSum;
            maxCol = col;
            maxRow = row;
        }

    }
}

Console.WriteLine($"Sum = {maxMatrixSum}");

for (int i = maxRow; i < maxRow + 3; i++)
{
    for (int j = maxCol; j < maxCol + 3; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}


