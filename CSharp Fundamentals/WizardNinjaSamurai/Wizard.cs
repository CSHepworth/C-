public class Wizard : Human
{
    public Wizard(string n) : base (n)
    {
        Strength = 5;
        Dexterity = 5;
        Intelligence = 25;
        Health = 50;
    }

    //Custom Wizard
    public Wizard(string n, int str, int dex, int intel, int hp) : base (n, str, dex, intel, hp)
    {
    }

    
    public int LifeDrain(Human target)
    {
        int dmg = Intelligence * 3;
        target.Health -= dmg;
        Health += dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damge and restored their health by {dmg} points!");
        return target.Health;
    }

    public int Heal(Human target)
    {
        int healing = Intelligence * 3;
        target.Health += healing;
        Console.WriteLine($"{Name} healed {target.Name} for {healing} heatlth!");
        return target.Health;
    }
}