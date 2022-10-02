public class Firearm : WeaponClass
{
    public string Name;
    public string Cartridge;
    public string Action;

    public Firearm(string n, string c, string a, string cn, string at, bool ifa) : base(cn, at, ifa)
    {
        Name = n;
        Cartridge = c;
        Action = a;
    }
}

