

using System.Linq;

string[] songs = Console.ReadLine().Split(", ").ToArray();

Queue<string> queueSongs = new Queue<string>(songs);


while (queueSongs.Count > 0)
{
    string[] command = Console.ReadLine().Split(" ").ToArray();


    if (command[0] == "Play")
    {
        queueSongs.Dequeue();

    }
    else if (command[0] == "Add")
    {
        string song = command[1];
        song = string.Join(" ", command.Skip(1));//Watch Me, Love Me Harder
        if (queueSongs.Contains(song))
        {
            Console.WriteLine($"{song} is already contained!");
        }
        else
        {
            queueSongs.Enqueue(song);
        }

    }
    else//command[0] == "Show")
    {
        Console.WriteLine(string.Join(", ", queueSongs));
    }
}
Console.WriteLine("No more songs!");


