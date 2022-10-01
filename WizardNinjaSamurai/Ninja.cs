public class Ninja : Human
{
    public Ninja(string n) : base (n)
    {
        Strength = 10;
        Dexterity = 75;
        Intelligence = 5;
        Health = 60;
    }

    //Custom Ninja
    public Ninja(string n, int str, int dex, int intel, int hp) : base (n, str, dex, intel, hp)
    {
    }

    public int Shuriken(Human target)
    {
        Random rand = new Random();
        int bonus = rand.Next(1, 6);
        if (bonus == 1)
        {
            int dmg = Dexterity += 10;
            Console.WriteLine($"CRITICAL HIT! {Name} attacked {target.Name} for {dmg} damage!");
            target.Health -= dmg;
        }
        else
        {
            int dmg = Dexterity;
            target.Health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        }
        return target.Health;
    }

    public int Steal(Human target)
    {
        int dmg = 5;
        target.Health -= dmg;
        Health += dmg;
        Console.WriteLine($"{Name} stole {dmg} health from {target.Name}!");
        return target.Health;
    }
}