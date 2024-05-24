
int size = int.Parse(Console.ReadLine()!);
char[,] matrix = new char[size, size];

for (int i = 0; i < size; i++)
{
    char[] row = Console.ReadLine()!.ToCharArray();
    for (int j = 0; j < size; j++)
    {
        matrix[i, j] = row[j];
    }
}

int removeKnight = 0;
for (int max = 8; max > 0; max--)
{
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            int endangered = 0;
            if (matrix[i, j] == 'K')
            {
                string[] moves =
                {//     y        x
                    $"{i + 2} {j + 1}",
                    $"{i + 2} {j - 1}",
                    $"{i - 2} {j + 1}",
                    $"{i - 2} {j - 1}",
                    $"{i + 1} {j + 2}",
                    $"{i + 1} {j - 2}",
                    $"{i - 1} {j + 2}",
                    $"{i - 1} {j - 2}"
                };

                foreach (string move in moves)
                {
                    int y = int.Parse(move.Split()[0]);
                    int x = int.Parse(move.Split()[1]);
                    if (y >= 0 && y < size &&
                        x >= 0 && x < size &&
                        matrix[y, x] == 'K')
                    {
                        endangered++;
                    }
                }
            }

            if (endangered == max)
            {
                matrix[i, j] = '0';
                removeKnight++;
            }
        }
    }
}

Console.WriteLine(removeKnight);