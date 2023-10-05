// SLUMP:

// Random generator = new Random();

// int slumptal = generator.Next(10, 20);

// Console.WriteLine(slumptal);


// WHILE LOOP

// int tal = 100;

// while (tal > 0)
// {
//     Console.WriteLine(tal);
//     tal++; eller tal--;
// }

// Console.WriteLine("Färdig!");


// METOD:

// static void SayHello()
// {
//     Console.WriteLine();
// }
// SayHello();

using System.Diagnostics;
using System.Linq.Expressions;

int YourHealth = 100;
int EnemyHealth = 100;

string You = "Karl Den Kristne";
string Enemy = "Average Non Believer";

Random generator = new Random();
int HolyBladeDamage = generator.Next(20);

Console.WriteLine("A new challenger dares approach you, how will you respond?");
Console.WriteLine("A) Swing at him ferociously. B) Try to reason with him. C) Invoke the lord.");

string action = Console.ReadLine().ToUpper();

if (action == "C")
{
    Console.WriteLine("As the enemy approaches, you get on your knees and start praying.");
    Console.WriteLine("During the prayer the clouds clear up and the sun starts shining brighter.");
    Console.WriteLine("The heat starts rising to unfathomable degrees, and as you open your eyes you can see the sun closing in on the earth.");
    Console.WriteLine("Everything you have ever gained is lost in an instant, but hey, at least he died. Was it worth it? The end.");
}

else
{
    if (action == "A")
    {
        EnemyHealth -= HolyBladeDamage;
        Console.WriteLine("You charge at the pleb with your holy blade");
        Console.WriteLine($"You manage to deal {HolyBladeDamage} damage to him.");
        Console.WriteLine($"He now has {EnemyHealth} health remaining");
        Console.WriteLine( );
    }

    if (action == "B")
    {
        Console.WriteLine("You start trying to reason with him but he keeps trying to turn you into one of his kind");
        Console.WriteLine("The battle eventually begins");
        Console.WriteLine( );
    }
                
    // FIGHT

    while (YourHealth > 0 && EnemyHealth > 0)
    {
        int YourDamage = generator.Next(20);
        int EnemyDamage = generator.Next(20);
        int ShieldBash = generator.Next(10);

        Console.WriteLine( );
        Console.WriteLine("----- _ * + A NEW ROUND COMMENCES + * _ -----");
        Console.WriteLine( );
        Console.WriteLine($"{You}: {YourHealth} -------------------- {Enemy}: {EnemyHealth}");
        Console.WriteLine("How will you respond? [Fight / Block / Shieldbash]");
        string fight = Console.ReadLine().ToLower();
        
        while(fight != "fight" && fight !="block" && fight !="shieldbash")
        {
            Console.WriteLine("That's not an option.");
            fight = Console.ReadLine().ToLower();
        }

        if (fight == "fight")
        {
            EnemyHealth -= YourDamage;
            Console.WriteLine($"You managed to deal {YourDamage} damage to the pesky non-christian.");
            YourHealth -= EnemyDamage;
            Console.WriteLine($"He quickly strikes you back dealing {EnemyDamage} damage to you");
        }

        else if (fight == "Block")
        {
            Console.WriteLine("You raise your shield and block his sword. You take no damage");
        }
        
        else if (fight == "Block")
        {
            EnemyHealth -= ShieldBash;
            YourHealth -= EnemyDamage - 3;
        }

        Console.ReadKey();
    }

}



Console.ReadLine();