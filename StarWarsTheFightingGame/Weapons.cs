using System;

public class Weapons
{
    private Random generator;

   
    public int minDamage = 8500;
    public int maxDamage = 16195;

    public Weapons()
    {
        generator = new Random(); //Skapar en slumpmässig numerisk värde
    }

    /*Metod för att få Damage mellan 8000-16000*/
    public int GetDamage()
    {
        return generator.Next(minDamage, maxDamage); 
    }
}










