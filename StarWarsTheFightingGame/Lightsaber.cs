using System;

public class Lightsaber : Weapons
{
    public string Name { get; } = "Lightsaber";

    public Lightsaber()
    {
        minDamage = 8500;
        maxDamage = 16195;
    }

    // Method to deal damage to a fighter
    public void DealDamage(Fighter target)
    {
        int damage = CalculateDamage();
        target.hp = Math.Max(0, target.hp - damage);
        Console.WriteLine($"{Name} deals {damage} damage to {target.name}.");
    }

    // Method to calculate damage
    private int CalculateDamage()
    {
        Random random = new Random();
        return random.Next(minDamage, maxDamage + 1);
    }

    // Quick Fix Gjorde detta
    public static implicit operator string(Lightsaber v)
    {
        return v.Name;
    }
}