using System;

public class Fighter
{
    public int hp = 80000;
    public string name;
    public string WeaponsName;

    public void Attack(Fighter target)
    {
        Random generator = new Random();
        int damage = generator.Next(8500, 16195); 
        target.hp = Math.Max(0, target.hp);
        target.hp -= damage;
        Console.WriteLine($"{name} did {damage} to {target.name}");
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
}





