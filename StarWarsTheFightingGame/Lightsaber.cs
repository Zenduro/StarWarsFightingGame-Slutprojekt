public class Lightsaber : Weapons
{
    public string Name { get; } = "Lightsaber";

    public Lightsaber()
    {
        minDamage = 8500;
        maxDamage = 16195;
    }

    // Quick Fix Gjorde detta
    public static implicit operator string(Lightsaber v)
    {
        return v.Name;
    }
}