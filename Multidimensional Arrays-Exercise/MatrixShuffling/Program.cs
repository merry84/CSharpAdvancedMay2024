

using System.Numerics;
using System.Xml.Linq;

int[] size = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = size[0];
int cols = size[1];
string[,] matrix = new string[rows, cols];

//пълним матрицата
for (int i = 0; i < rows; i++)
{
    string[] numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
     ;
    for (int j = 0; j < cols; j++)
    {
        matrix[i, j] = numbers[j];
    }
}
string command;
while ((command = Console.ReadLine()) != "END")
{
    string[] elements = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

    if (!InMatix(matrix, elements))
    {
        Console.WriteLine("Invalid input!");
        continue;
    }
    int row1 = int.Parse(elements[1]);
    int col1 = int.Parse(elements[2]);
    int row2 = int.Parse(elements[3]);
    int col2 = int.Parse(elements[4]);
    (matrix[row1, col1], matrix[row2, col2]) = (matrix[row2, col2], matrix[row1, col1]);
    PrintMatrix(matrix);
}


static void PrintMatrix(string[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
static bool InMatix(string[,] matrix, string[] elements)
{
    if (elements[0] != "swap" || elements.Length != 5)
    {
        return false;
    }
    int row1 = int.Parse(elements[1]);
    int col1 = int.Parse(elements[2]);
    int row2 = int.Parse(elements[3]);
    int col2 = int.Parse(elements[4]);
    return row1 >= 0 && row1 < matrix.GetLength(0)
                             && row2 >= 0 && row2 < matrix.GetLength(0)
                             && col1 >= 0 && col1 < matrix.GetLength(1)
                             && col2 >= 0 && col2 < matrix.GetLength(1);
}
