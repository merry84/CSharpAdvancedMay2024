

int[] size = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = size[0];
int cols = size[1];
char[,] matrix = new char[rows, cols];

//пълним матрицата
for (int i = 0; i < rows; i++)
{
    char[] numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(char.Parse)
    .ToArray(); ;
    for (int j = 0; j < cols; j++)
    {
        matrix[i, j] = numbers[j];
    }
}

int countMatrixSquere = 0;
for (int i = 0; i < matrix.GetLength(0) - 1; i++)// за да не излезнем от матрицата
{
    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
    {
        // kвадратна матрица от 2 реда и 2 колони
        if (matrix[i, j] == matrix[i + 1, j] &&
             matrix[i, j] == matrix[i, j + 1] &&
             matrix[i, j] == matrix[i + 1, j + 1])
        {
            countMatrixSquere++;
        }


    }
}
Console.WriteLine(countMatrixSquere);