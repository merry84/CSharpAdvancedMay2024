
int priceBullet = int.Parse(Console.ReadLine());//цена

int sizeGun = int.Parse(Console.ReadLine());//размер на цев

int[] bullets = Console.ReadLine()// куршуми
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int[] locks = Console.ReadLine()// ключалки
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int intelligenceValue = int.Parse(Console.ReadLine());// интелигентност

Stack<int> stackBullets =new(bullets);
Queue<int> queueLocks = new (locks);

int counterBarrels = 0;

//If the bullet has a smaller or equal size to the current lock, print "Bang!",
//then remove the lock. If not, print "Ping!", leaving the lock intact. The bullet is removed in both cases.

while (queueLocks.Count > 0 && stackBullets.Count > 0)
{
    if (stackBullets.Peek() <= queueLocks.Peek())
    {
        Console.WriteLine("Bang!");
        queueLocks.Dequeue();
        stackBullets.Pop();
        counterBarrels++;
    }
    else
    {
        Console.WriteLine("Ping!");
        stackBullets.Pop();
        counterBarrels++;
    }
    //If Sam runs out of bullets in his barrel, print "Reloading!" in the console, then continue shooting. If there aren't any bullets left, don't print it.
    if (stackBullets.Any() && counterBarrels % sizeGun == 0)
    {
        Console.WriteLine("Reloading!");
    }
}
//•	 If Sam runs out of bullets before the safe runs out of locks, print
//Couldn't get through. Locks left: {locksLeft}".
if (!stackBullets.Any() && queueLocks.Count > 0)
{
    Console.WriteLine($"Couldn't get through. Locks left: {queueLocks.Count}");
}
else//•	If Sam manages to open the safe, print
   //"{bulletsLeft} bullets left. Earned ${moneyEarned}".
//Make sure to account for the price of the bullets when calculating the money earned.

{
    int moneyEarned = priceBullet * counterBarrels;
    Console.WriteLine($"{stackBullets.Count} bullets left. Earned ${intelligenceValue - moneyEarned}");
}


