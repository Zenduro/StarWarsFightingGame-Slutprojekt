﻿using System;

public class Fighter
{
    public int hp = 80000;
    public string name;
    public string WeaponsName;

    public void Attack(Fighter target) // Attack metod
    {
        if (WeaponsName == "Lightsaber") // if sats, den kollar att weaponsname är exakt lightsaber. Om det är sant gör den en ny objekt av lightsaber.
        {
            new Lightsaber().DealDamage(target); // Det gör en ny objekt av lightsaber 
        }
        else
        {
            Console.WriteLine($"{name} attacks {target.name}."); // Skriver ut namn och som attackerar target, min gubbe och fienden
        }
    }

    public static implicit operator Fighter(MaceWindu M) /*M används för att initiera motsvarande egenskaper för Fighter-objektet*/
    {
        Fighter fighter = new Fighter();
        fighter.name = M.name;
        fighter.WeaponsName = M.Weaponsname;
        return fighter;
    }

    public static implicit operator Fighter(Ashoka A) /**/
    {
        Fighter fighter = new Fighter();
        fighter.name = A.name;
        fighter.WeaponsName = A.Weaponsname;
        return fighter;
    }

    public static implicit operator Fighter(Luke L)
    {
        Fighter fighter = new Fighter();
        fighter.name = L.name;
        fighter.WeaponsName = L.Weaponsname;
        return fighter;
    }

    public static implicit operator Fighter(DarthMaul DM)
    {
        Fighter fighter = new Fighter();
        fighter.name = DM.name;
        fighter.WeaponsName = DM.Weaponsname;
        return fighter;
    }

    public static implicit operator Fighter(Yoda Y)
    {
        Fighter fighter = new Fighter();
        fighter.name = Y.name;
        fighter.WeaponsName = Y.Weaponsname;
        return fighter;
    }

    public static implicit operator Fighter(Palpatine P)
    {
        Fighter fighter = new Fighter();
        fighter.name = P.name;
        fighter.WeaponsName = P.Weaponsname;
        return fighter;
    }
    public static implicit operator Fighter(ObiWan O)
    {
        Fighter fighter = new Fighter();
        fighter.name = O.name;
        fighter.WeaponsName = O.Weaponsname;
        return fighter;
    }
    public static implicit operator Fighter(Anakin AK)
    {
        Fighter fighter = new Fighter();
        fighter.name = AK.name;
        fighter.WeaponsName = AK.Weaponsname;
        return fighter;
    }
     public static implicit operator Fighter(KiatMundi KM)
    {
        Fighter fighter = new Fighter();
        fighter.name = KM.name;
        fighter.WeaponsName = KM.Weaponsname;
        return fighter;
    }
}





