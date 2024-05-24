/*5 6
SoftUni
SoftUn
UtfoSi
niSoft
foSinU
tUniSo

 */

int[] sizes = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int rows = sizes[0];
int cols = sizes[1];
char[,] matrix = new char[rows, cols];

string text = Console.ReadLine();
int indexOfText = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    //  //при четен ред 0->последен индекс
    if (i % 2 == 0)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = text[indexOfText];
            indexOfText++;

            if (indexOfText >= text.Length)//ао индекса е >= на дължината на текста започваме от 0 индекс
            {
                indexOfText = 0;
            }
        }
    }
    //// при нечетен от поледен index -> 0 индекс
    else
    {

        for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
        {
            matrix[i, j] = text[indexOfText];
            indexOfText++;

            if (indexOfText >= text.Length)//ао индекса е >= на дължината на текста започваме от 0 индекс
            {
                indexOfText = 0;
            }
        }


    }
}
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j]);
    }
    Console.WriteLine();
}
