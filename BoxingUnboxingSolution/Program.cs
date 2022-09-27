List<object> items = new List<object>();

items.Add(7);
items.Add(28);
items.Add(-1);
items.Add(true);
items.Add("chair");

int sum = 0;

foreach (var item in items)
{
    Console.WriteLine(item);

        if (item is int)
        {
            sum += (int)item;
        }
}

Console.WriteLine(sum);