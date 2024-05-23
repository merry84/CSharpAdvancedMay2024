
string[] size = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

int rows = int.Parse(size[0]);
int cols = int.Parse(size[1]);
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
//обръщаме форовете за да намерим сумата на всяка колона
// и да вървим по колоните
for (int i = 0; i < cols; i++)
{
    int sumCols = 0;
    for (int j = 0; j < rows; j++)
    {
        sumCols += matrix[j, i];
    }
    Console.WriteLine(sumCols);
}