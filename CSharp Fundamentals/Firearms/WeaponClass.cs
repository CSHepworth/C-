public class WeaponClass
{
    public string ClassName;
    public string AmmoType;
    public bool IsFullAuto;

    public WeaponClass(string cn, string at, bool ifa)
    {
        ClassName = cn;
        AmmoType = at;
        IsFullAuto = ifa;
    }
}