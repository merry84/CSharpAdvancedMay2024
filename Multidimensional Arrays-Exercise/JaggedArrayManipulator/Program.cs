
int rows = int.Parse(Console.ReadLine());
int[][] matrix = new int[rows][];
for (int i = 0; i < matrix.Length; i++)
{
    matrix[i] = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();
}

//After populating the matrix, start analyzing it.
//If a row and the one below it have equal length, multiply each element in both of them by 2,
//otherwise - divide by 2.

//провека дали има редове с еднаква дължина

for (int i = 0; i < matrix.GetLength(0) - 1; i++)
{
    if (matrix[i].Length == matrix[i + 1].Length)//multiply each element in both of them by 2,
    {
        matrix[i] = matrix[i].Select(x => x * 2).ToArray();
        matrix[i + 1] = matrix[i + 1].Select(x => x * 2).ToArray();
    }
    else// divide by 2.
    {
        matrix[i] = matrix[i].Select(x => x / 2).ToArray();
        matrix[i + 1] = matrix[i + 1].Select(x => x / 2).ToArray();
    }
}



string command;
while ((command = Console.ReadLine()) != "End")
{
    string[] tokens = command.Split(' ');
    int row = int.Parse(tokens[1]);
    int column = int.Parse(tokens[2]);
    int value = int.Parse(tokens[3]);
    // проверка дали е в матрицата
    if (row < 0 || row >= matrix.Length ||
        matrix[row].Length <= column || column < 0)
    {//ако излиза от координатите
        continue;
    }
    else if (tokens[0] == "Add")
    {
        matrix[row][column] += value;
    }
    else if (tokens[0] == "Subtract")
    {
        matrix[row][column] -= value;
    }

}
foreach (var number in matrix)
{
    Console.WriteLine(string.Join(" ", number));
}