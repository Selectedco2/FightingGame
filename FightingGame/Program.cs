
// OBS!!! FORTSÄTTER PÅ DENNA SOM MITT VINTER-PROJEKT!

// METOD:

// static void SayHello()
// {
//     Console.WriteLine();
// }
// SayHello();

// Variabler och Arrays osv

using System.Collections;
using System.IO.Pipes;

int[] EnemyHP = {100, 150, 200};
int[] HP = {100, 200, 50};
int[] DodgeChances = {20, 10, 50};
string[] Characters = {"Karl Den Kristne", "Rustade Ragnar", "Smygande Smilla"};
string[] Enemies = {"Grunt", "Cyclops", "The Devil"};
string [] Loot1 = {"A Small gold pile", "An axe", "An iron Helmet"};
string [] Loot2 = {"A giant tooth", "A Zweihänder", "A chestplate"};
string [] Loot3 = {"A golden crown", "A hellish pitchfork", "A horn of summoning"};
bool replay = true;
Random Dice = new Random();
int HolyBladeDamage = Dice.Next(20);
int cChoice = 0;
int currentEnemy = 0;
Characters[Loot]
int Loot = Dice.Next(Characters.Length);


// metod
// -------------------------------------------
static void Skriv_Något_Här()
{
    Console.WriteLine("Något spännande");
}
// -------------------------------------------
while (replay == true)
{
Console.Clear();
Console.WriteLine("Choose your class! 1). Karl Den Kristne | 2). Rustade Ragnar | 3). Smygande Smilla");
string val = Console.ReadLine();
bool cSelect = int.TryParse(val, out cChoice);

// "Lore"

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
        EnemyHP[currentEnemy] -= HolyBladeDamage;
        Console.WriteLine("You charge at the pleb with your holy blade");
        Console.WriteLine($"You manage to deal {HolyBladeDamage} damage to him.");
        Console.WriteLine($"He now has {EnemyHP[currentEnemy]} health remaining");
        Console.WriteLine( );
    }

    if (action == "B")
    {
        Console.WriteLine("You start trying to reason with him but he keeps trying to turn you away from your saviour");
        Console.WriteLine("The battle eventually begins");
        Console.ReadKey();
    }
                
    // FIGHT
    
    
        while (HP[cChoice-1] > 0 && EnemyHP[currentEnemy] > 0)
    {
        int YourDamage = Dice.Next(20);
        float EnemyDamage = Dice.Next(20);
        int ShieldBash = Dice.Next(10);

        Console.WriteLine( );
        Console.WriteLine("----- _ * + A NEW ROUND COMMENCES + * _ -----");
        Console.WriteLine( );
        Console.WriteLine($"{Characters[cChoice-1]}: {HP[cChoice-1]} -------------------- {Enemies[currentEnemy]}: {EnemyHP[currentEnemy]}");
        Console.WriteLine("How will you respond? [Slash / Block / Ram]");
        string fight = Console.ReadLine().ToLower();
        
        while(fight != "slash" && fight !="block" && fight !="ram")
        {
            Console.WriteLine("That's not an option.");
            fight = Console.ReadLine().ToLower();
        }

        if (fight == "slash")
        {
            EnemyHP[currentEnemy] -= YourDamage;
            Console.WriteLine($"You managed to deal {YourDamage} damage to the pesky non-christian.");
            HP[cChoice-1] -= (int)(EnemyDamage);
            Console.WriteLine($"He quickly strikes you back dealing {EnemyDamage} damage to you");
        }

        else if (fight == "block")
        {
            Console.WriteLine("You raise your shield and block his sword. You take no damage");
        }
        
        else if (fight == "ram")
        {
            EnemyHP[currentEnemy] -= ShieldBash;
            HP[cChoice-1] -= (int)(EnemyDamage * 0.5f);
            Console.WriteLine($"{Characters[cChoice-1]} ram's the enemy with his shield, dealing {ShieldBash} damage while also taking a reduced {EnemyDamage} damage.");
        }
    }
    // Endscreen / Loss / Victory / replay

    }
    if (HP[cChoice-1] <= 0)
    {
        Console.WriteLine("You fall to your knees and surrender your blade. He swiftly cuts off your neck.");
        Console.WriteLine("Would you like to play again? [Yes / No]");
        string omstart = Console.ReadLine().ToLower();
    
    if (omstart != "yes")
    {
        replay = false; 
        Console.WriteLine("Okay, thank you for playing! Press any key to exit.");
        Console.ReadKey();
    }

    }
        
    if (EnemyHP[currentEnemy] <= 0)
    {
        currentEnemy++;
        Console.WriteLine("Would you like to pillage the enemies body? [Yes / No]");
        string pillage = Console.ReadLine().ToLower();
        if (pillage == "yes")
        {
            
        }
        Console.WriteLine("Ready to face your next opponent?");
        Console.ReadLine();
    }
    
}