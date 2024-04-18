using System;

class Program
{
    static void Main(string[] args) //executar programet, börjar här ifrån. 
    {
        Console.WriteLine("Welcome to Star Wars: The Fighting Game!");
        Console.WriteLine("Choose your character:");
        Console.WriteLine("1. Obi-Wan");
        Console.WriteLine("2. Anakin Skywalker");
        Console.WriteLine("3. Mace Windu");
        Console.WriteLine("4. Ashoka");
        Console.WriteLine("5. Luke Skywalker");
        Console.WriteLine("6. Darth Maul");
        Console.WriteLine("7. Yoda");
        Console.WriteLine("8. Palpatine");
        Console.WriteLine("9. Kiat Mundi"); 
        Console.Write("Enter your choice: ");

        /*Läser vem Spelaren har valt som karaktär*/
        int choice = int.Parse(Console.ReadLine());

        
        Fighter fighter1, fighter2;

        switch (choice)
        {
            case 1:
                fighter1 = new ObiWan();
                break;
            case 2:
                fighter1 = new Anakin();
                break;
            case 3:
                fighter1 = new MaceWindu();
                break;
            case 4:
                fighter1 = new Ashoka();
                break;
            case 5:
                fighter1 = new Luke();
                break;
            case 6:
                fighter1 = new DarthMaul();
                break;
            case 7:
                fighter1 = new Yoda();
                break;
            case 8:
                fighter1 = new Palpatine();
                break;
            case 9: 
                 fighter1 = new KiatMundi(); 
                 break; 
            default: 
                Console.WriteLine("Invalid choice. Exiting game.");
                return;
        }

        Console.WriteLine("Choose opponent:");
        Console.WriteLine("1. Obi-Wan");
        Console.WriteLine("2. Anakin Skywalker");
        Console.WriteLine("3. Mace Windu");
        Console.WriteLine("4. Ashoka");
        Console.WriteLine("5. Luke Skywalker");
        Console.WriteLine("6. Darth Maul");
        Console.WriteLine("7. Yoda");
        Console.WriteLine("8. Palpatine");
        Console.WriteLine("9. KiatMundi"); 
        Console.Write("Enter your choice: ");

        /*Vem man möter i splet*/
        int opponentChoice = int.Parse(Console.ReadLine());

        /*Den motståndare Spleraren har valt*/
        switch (opponentChoice)
        {
            case 1:
                fighter2 = new ObiWan();
                break;
            case 2:
                fighter2 = new Anakin();
                break;
            case 3:
                fighter2 = new MaceWindu();
                break;
            case 4:
                fighter2 = new Ashoka();
                break;
            case 5:
                fighter2 = new Luke();
                break;
            case 6:
                fighter2 = new DarthMaul();
                break;
            case 7:
                fighter2 = new Yoda();
                break;
            case 8:
                fighter2 = new Palpatine();
                break;
            case 9: 
                 fighter2 = new KiatMundi(); 
                 break; 
            default:
                Console.WriteLine("Invalid choice. Exiting game.");
                return;
        }

        /*Lägger spelarens namn*/
        fighter1.name = GetCharacterName(choice);
        fighter2.name = GetCharacterName(opponentChoice);

        //Sätter spelarens Vapen
        fighter1.WeaponsName = new Lightsaber();
        fighter2.WeaponsName = new Lightsaber();
        fighter2.WeaponsName = "Lightsaber";

        // Startar spelet efter alla val
        StartGame(fighter1, fighter2);

        Console.ReadLine();
    }

    static string GetCharacterName(int choice)
    {
        switch (choice)
        {
            case 1:
                return "Obi-Wan";
            case 2:
                return "Anakin Skywalker";
            case 3:
                return "Mace Windu";
            case 4:
                return "Ashoka";
            case 5:
                return "Luke Skywalker";
            case 6:
                return "Darth Maul";
            case 7:
                return "Yoda";
            case 8:
                return "Palpatine";
            case 9: 
                 return "KiatMundi"; 
            default:
                return "";
        }
    }

    static void StartGame(Fighter fighter1, Fighter fighter2)
    {
        Random generator = new Random();

        while (fighter1.hp > 0 && fighter2.hp > 0)
        {
            Console.WriteLine($"{fighter1.name}:{fighter1.hp} || {fighter2.name}: {fighter2.hp}");

            fighter1.Attack(fighter2);
            fighter2.Attack(fighter1);
        }

        if (fighter1.hp == 0 && fighter2.hp == 0) //beräknar ifall båda gubbarna har 0 så blir det då draw.
        {
            Console.WriteLine($"DRAW");
        }
        else if (fighter2.hp == 0)
        {
            Console.WriteLine($"I Was At Last The Strongest! {fighter1.name} WINS!");
        }
        else
        {
            Console.WriteLine($"You Underestimated My Power! {fighter2.name} WINS!");
        }
    }
}

