namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];

            int beeRow = 0;
            int beeCol = 0;

            int nectar = 0;
            int energy = 15;
            int restoreEnergy = 1;//The energy can be restored only once.

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] rows = Console.ReadLine().ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rows[j];
                    if (matrix[i, j] == 'B')
                    {
                        beeRow = i;
                        beeCol = j;
                    }
                }
            }

            string input;
            while ((input = Console.ReadLine()) != null)
            {
                matrix[beeRow, beeCol] = '-';
                //You will be given commands for the bee's movement. The commands will be: "up", "down", "left", and "right".
                //The bee moves towards the given direction. With each move, the bee's energy decreases by 1 unit.
                if (input == "up")
                {
                    //•	If the bee leaves the field (goes out of the boundaries of the matrix) depending on the move command,
                    //it will be moved to the opposite side of the field.

                    if (beeRow == 0)
                    {
                        beeRow = size - 1;
                    }
                    else
                    {
                        beeRow -= 1;
                    }
                }
                else if (input == "down")
                {
                    if (beeRow == size - 1)
                    {
                        beeRow = 0;
                    }
                    else
                    {
                        beeRow += 1;
                    }
                }
                else if (input == "left")
                {
                    if (beeCol == 0)
                    {
                        beeCol = size - 1;
                    }
                    else
                    {
                        beeCol -= 1;
                    }
                }
                else if (input == "right")
                {
                    if (beeCol == size - 1)
                    {
                        beeCol = 0;
                    }
                    else
                    {
                        beeCol += 1;
                    }
                }
                energy--;

                if (char.IsDigit(matrix[beeRow, beeCol]))//flower position
                {
                    nectar += matrix[beeRow, beeCol]-'0';
                    matrix[beeRow, beeCol] = '-';
                }
                else if (matrix[beeRow, beeCol] == 'H')//hive position
                {

                    if (nectar >= 30)
                    {
                        Console.WriteLine($"Great job, Beesy! The hive is full. Energy left: {energy}");
                    }
                  
                    else 
                    {
                        Console.WriteLine($"Beesy did not manage to collect enough nectar.");
                    }
                    matrix[beeRow, beeCol] = 'B';

                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {

                            Console.Write(matrix[i, j]);
                        }
                        Console.WriteLine();
                    }
                    return;
                }
                
                if (energy == 0)
                {
                    //•	If the bee runs out of energy and the total amount of collected nectar is at least 30 units,
                    //the energy will be restored with the amount of the difference between the nectar collected up to this turn and the minimum required amount for making honey (30).
                    //The value of the collected nectar is dropped to 30 units
                    if (nectar >= 30 && restoreEnergy == 1)
                    {
                        int diffAmount = nectar - 30;
                        energy += diffAmount;
                        nectar = 30;
                        restoreEnergy = 0;
                        //Console.WriteLine($"Great job, Beesy! The hive is full. Energy left: {energy}");
                        matrix[beeRow, beeCol] = '-';
                    }
                    else
                    {

                        Console.WriteLine($"This is the end! Beesy ran out of energy.");
                        matrix[beeRow, beeCol] = 'B';

                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {

                                Console.Write(matrix[i, j]);
                            }
                            Console.WriteLine();
                        }
                        return;
                    }


                }
                matrix[beeRow, beeCol] = 'B';
            }
        }
    }
}
