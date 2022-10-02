public class Human
{
    public string Name;
    public int Strength;
    public int Dexterity;
    public int Intelligence;
    public int Health;

    public Human(string n, int str, int dex, int intel, int hp)
    {
        Name = n;
        Strength = str;
        Dexterity = dex;
        Intelligence = intel;
        Health = hp;
    }

    public Human(string n)
    {
        Name = n;
        Strength = 30;
        Dexterity = 30;
        Intelligence = 30;
        Health = 100;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Strength: {Strength}");
        Console.WriteLine($"Dexterity: {Dexterity}");
        Console.WriteLine($"Intelligence: {Intelligence}");
        Console.WriteLine($"Health: {Health}");
    }

    public int Attack(Human target)
    {
        int dmg = Strength * 3;
        target.Health -= dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        return target.Health;
    }
}