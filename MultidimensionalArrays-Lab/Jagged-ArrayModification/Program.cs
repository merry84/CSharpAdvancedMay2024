/*
4
1 2 3 4
5
8 7 6 5
4 3 2 1
Add 4 4 100
Add 3 3 100
Subtract -1 -1 42
Subtract 0 0 42
END
*/

int rows = int.Parse(Console.ReadLine());
int[][] matrix = new int[rows][];
for (int i = 0; i < matrix.Length; i++)
{
    matrix[i] = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();
}

string command;
while ((command = Console.ReadLine()) != "END")
{
    string[] tokens = command.Split(' ');
    int row = int.Parse(tokens[1]);
    int column = int.Parse(tokens[2]);
    int value = int.Parse(tokens[3]);
    // проверка дали е в матрицата
    if (row < 0 || row >= matrix.Length
        ||
        matrix[row].Length <= column || column < 0)
    {//ако излиза от координатите
        Console.WriteLine("Invalid coordinates");
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