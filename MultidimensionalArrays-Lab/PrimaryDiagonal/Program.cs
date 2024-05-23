// See https://aka.ms/new-console-template for more information

int size = int.Parse(Console.ReadLine());
int rows = size;
int cols = size;
int[,] matrix = new int[rows, cols];

//пълним матрицата
for (int i = 0; i < rows; i++)
{
    string[] numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
    for (int j = 0; j < cols; j++)
    {
        matrix[i, j] = int.Parse(numbers[j]);
    }
}
int sumDiagonal = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    // int col = row;
    sumDiagonal += matrix[i, i];// red 0 = col 0 ,red 1= col 1

}
Console.WriteLine(sumDiagonal);


