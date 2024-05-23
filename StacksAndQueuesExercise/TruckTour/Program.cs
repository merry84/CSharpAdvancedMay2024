
int pumps = int.Parse(Console.ReadLine());

Queue<int[]> queuePumps = new Queue<int[]>();
for (int i = 0; i < pumps; i++)
{

    int[] tokens = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();
    queuePumps.Enqueue(tokens);

}

int tour = 0;
while (true)
{
    int tankLittre = 0;//литри в резервоара
    foreach (int[] pump in queuePumps)
    {
        tankLittre += pump[0];//добавяме гориво
        int distance = pump[1];
        if (tankLittre - distance < 0)//няма достатъчно гориво
        {
            tankLittre = 0;// отива на следващата помпа
            break;
        }
        else
        {

            tankLittre -= distance;//изваждаме горивото
        }

    }
    //след като сме проверили всички и има още гориво в резервоара
    if (tankLittre > 0) break;//спираме програмата
    tour++;
    queuePumps.Enqueue(queuePumps.Dequeue());//добавяме текущата помпа отзад на опашката 

}
// най-малкият индекс на бензиновата помпа, от която можем да започнем обиколката.
Console.WriteLine(tour);