static void RandomArray()
{
    int [] randarr = new int[10];
    Random rand = new Random();
    for (int i = 0; i < randarr.Length; i++)
    {
        randarr[i] = rand.Next(5, 26);
        Console.WriteLine(randarr[i]);
    }
}

RandomArray();


static void TossCoin()
{
    Console.WriteLine("Tossing a Coin!");
    Random rand = new Random();
    int result = rand.Next(0, 2);
    if (result == 0)
    {
        Console.WriteLine("Heads");
    }
    else
    {
        Console.WriteLine("Tails");
    }
}

TossCoin();


static void TossCoins(int times)
{
    for (int i = 0; i < times; i++)
    {
        Console.WriteLine("Tossing a Coin!");
        Random rand = new Random();
        int result = rand.Next(0, 2);
        if (result == 0)
        {
            Console.WriteLine("Heads");
        }
        else
        {
            Console.WriteLine("Tails");
        }
    }
}

TossCoins(10);


static void ListofStrings()
{
    List<string> names = new List<string>() {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
    for (int i = 0; i < names.Count; i++)
    {
        if (names[i].Length <= 5)
        {
            names.RemoveAt(i);
        }
    }
    foreach (string name in names)
    {
        Console.WriteLine(name);
    }
}

ListofStrings();