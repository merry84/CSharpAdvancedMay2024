


int rows = int.Parse(Console.ReadLine());
long[][] matrix = new long[rows][];
for (int i = 0; i < rows; i++)
{
    matrix[i] = new long[i + 1];// ПЪрвият ред винаги е 1
    for (int j = 0; j < matrix[i].Length; j++)
    {
        if (i == 0)
        {
            matrix[i][j] = 1;
            continue;
        }
        if (j < matrix[i - 1].Length)
        {
            matrix[i][j] += matrix[i - 1][j];
        }
        if (j > 0)
        {
            matrix[i][j] += matrix[i - 1][j - 1];
        }
    }
}

foreach (var number in matrix)
{
    Console.WriteLine(string.Join(" ", number));
}