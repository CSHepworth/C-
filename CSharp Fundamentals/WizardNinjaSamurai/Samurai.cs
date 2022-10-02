public class Samurai : Human
{
    public Samurai(string n) : base (n)
    {
        Strength = 40;
        Dexterity = 25;
        Intelligence = 5;
        Health = 200;
    }

    //Custom Samurai
    public Samurai(string n, int str, int dex, int intel, int hp) : base (n, str, dex, intel, hp)
    {
    }

    public int Disembowel(Human target)
    {
        base.Attack(target);
        if (target.Health < 50)
        {
            target.Health = 0;
            Console.WriteLine($"INSTAKILL! {target.Name} was defeated by {Name}!");
        }
        return target.Health;
    }

    public int Meditate()
    {
        Health = 200;
        Console.WriteLine($"{Name} meditated and was restored to full health!");
        return Health;
    }
}