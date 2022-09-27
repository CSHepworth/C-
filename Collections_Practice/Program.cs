int [] arr1 = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

string [] names = {"Tim", "Martin", "Nikki", "Sara"};

bool [] arr3 = {true, false, true, false, true, false, true, false, true, false};

List<string> flavors = new List<string>() {"Chocolate", "Vanilla", "Rocky Road", "Moose Tracks", "Pralines and Cream"};

Console.WriteLine(flavors.Count);
Console.WriteLine(flavors[2]);
flavors.RemoveAt(2);
Console.WriteLine(flavors.Count);

Dictionary<string, string> profile = new Dictionary<string, string>();
for (int i = 0; i < names.Length; i++)
{
    Random rand = new Random();
    profile.Add(names[i], flavors[rand.Next(0, flavors.Count-1)]);
}
foreach (KeyValuePair<string, string> entry in profile)
{
    Console.WriteLine(entry.Key + " - " + entry.Value);
}