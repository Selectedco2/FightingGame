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

int Character1Health = 100;
int Character2Health = 200;
int Character3Health = 50;
int EnemyHealth = 100;

string Character1 = "Karl Den Kristne";
string Character2 = "Rustade Ragnar";
string Character3 = "Smygande Smilla";

string Enemy = "Average Non Believer";

Random generator = new Random();
int HolyBladeDamage = generator.Next(20);

string chartacterSelection = Console.ReadLine();
if (chartacterSelection == Character1)
{

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
        Console.ReadKey();
    }
                
    // FIGHT
    while (Character1Health > 0 && EnemyHealth > 0)
    {
        int YourDamage = generator.Next(20);
        float EnemyDamage = generator.Next(20);
        int ShieldBash = generator.Next(10);

        Console.WriteLine( );
        Console.WriteLine("----- _ * + A NEW ROUND COMMENCES + * _ -----");
        Console.WriteLine( );
        Console.WriteLine($"{Character1}: {Character1Health} -------------------- {Enemy}: {EnemyHealth}");
        Console.WriteLine("How will you respond? [Slash / Block / ShieldRam]");
        string fight = Console.ReadLine().ToLower();
        
        while(fight != "slash" && fight !="block" && fight !="shieldram")
        {
            Console.WriteLine("That's not an option.");
            fight = Console.ReadLine().ToLower();
        }

        if (fight == "slash")
        {
            EnemyHealth -= YourDamage;
            Console.WriteLine($"You managed to deal {YourDamage} damage to the pesky non-christian.");
            Character1Health -= (int)(EnemyDamage);
            Console.WriteLine($"He quickly strikes you back dealing {EnemyDamage} damage to you");
        }

        else if (fight == "block")
        {
            Console.WriteLine("You raise your shield and block his sword. You take no damage");
        }
        
        else if (fight == "shieldram")
        {
            EnemyHealth -= ShieldBash;
            Character1Health -= (int)(EnemyDamage * 0.5f);
            Console.WriteLine($"{Character1} ram's the enemy with his shield, dealing {ShieldBash} damage while also taking a reduced {EnemyDamage} damage.");
        }
    }
    if (Character1Health < 0 && Character2Health < 0 && Character3Health < 0)
    {
        Console.WriteLine("");
    }

        Console.ReadKey();
    }

}



Console.ReadLine();