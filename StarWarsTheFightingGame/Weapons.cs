using System;

public class Weapons
{
    private Random generator;

   
    public int minDamage = 8500;
    public int maxDamage = 16195;

    public Weapons()
    {
        generator = new Random();
    }

    /*Metod för att få Damage*/
    public int GetDamage()
    {
        return generator.Next(minDamage, maxDamage);
    }
}










