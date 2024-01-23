
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

// String för alla enemies
Item BackPack = new Item();
BackPack.itemName = "An axe";
BackPack.itemDamage = 10;


Enemy grunt = new Enemy();
grunt.name = "Grunt";
grunt.hp = 100;
grunt.loot = new string[] {"A Small gold pile", "An axe", "An iron Helmet"};

Enemy cyclops = new Enemy();
cyclops.name = "Cyclops";
cyclops.hp = 150;
cyclops.loot = new string[] {"A giant tooth", "A Zweihänder", "A chestplate"};

Enemy Devil = new Enemy();  
Devil.name = "The Devil";
Devil.hp = 200;
Devil.loot = new string[] {"A golden crown", "A hellish pitchfork", "A horn of summoning"};

List<Enemy> enemies = new();
enemies.Add(grunt);
enemies.Add(cyclops);
enemies.Add(Devil);

// enemies[0].loot / ememies[1].loot för att ge looten beroende på nollbaserad lista

Enemy currentEnemy = grunt;
int[] EnemyHP = {100, 150, 200};
int[] HP = {100, 200, 50};
int[] DodgeChances = {20, 10, 50};
string[] Characters = {"Karl Den Kristne", "Rustade Ragnar", "Smygande Smilla"};
bool replay = true;
Random Dice = new Random();
int HolyBladeDamage = Dice.Next(20);
int cChoice = 0;

int currentEnemyNum = 0;


// metod för vad commandot inventory ska visa

static void Inventory()

{
    Console.WriteLine("----------------------------------");
    Console.WriteLine();
}


while (replay == true)
{
Console.Clear();
Console.WriteLine("Choose your class! 1). Karl Den Kristne | 2). Rustade Ragnar | 3). Smygande Smilla");
string val = Console.ReadLine().ToLower();

while (val != "1" && val !="2" && val !="3")
{
    Console.WriteLine("That's not an option.");
    val = Console.ReadLine().ToLower();
}

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
        currentEnemy.hp -= HolyBladeDamage;
        Console.WriteLine("You charge at the pleb with your holy blade");
        Console.WriteLine($"You manage to deal {HolyBladeDamage} damage to him.");
        Console.WriteLine($"He now has {currentEnemy.hp} health remaining");
        Console.WriteLine( );
    }

    if (action == "B")
    {
        Console.WriteLine("You start trying to reason with him but he keeps trying to turn you away from your saviour");
        Console.WriteLine("The battle eventually begins");
        Console.ReadKey();
    }
                
    // selection
    
    
        while (HP[cChoice-1] > 0 && currentEnemy.hp > 0)
    {
        int YourDamage = Dice.Next(20);
        float EnemyDamage = Dice.Next(20);
        int ShieldBash = Dice.Next(10);

        Console.WriteLine( );
        Console.WriteLine("----- _ * + A NEW ROUND COMMENCES + * _ -----");
        Console.WriteLine( );
        Console.WriteLine($"{Characters[cChoice-1]}: {HP[cChoice-1]} -------------------- {currentEnemy.name}: {currentEnemy.hp}");
        Console.WriteLine("How will you respond? [Slash / Block / Ram / Inventory]");
        string selection = Console.ReadLine().ToLower();
        
        while(selection != "slash" && selection !="block" && selection !="ram" && selection != "inventory")
        {
            Console.WriteLine("That's not an option.");
            selection = Console.ReadLine().ToLower();
        }

        if (selection == "slash")
        {
            currentEnemy.hp -= YourDamage;
            Console.WriteLine($"You managed to deal {YourDamage} damage to the pesky non-christian.");
            HP[cChoice-1] -= (int)(EnemyDamage);
            Console.WriteLine($"He quickly strikes you back dealing {EnemyDamage} damage to you");
        }

        else if (selection == "block")
        {
            Console.WriteLine("You raise your shield and block his sword. You take no damage");
        }
        
        else if (selection == "ram")
        {
            currentEnemy.hp -= ShieldBash;
            HP[cChoice-1] -= (int)(EnemyDamage * 0.5f);
            Console.WriteLine($"{Characters[cChoice-1]} ram's the enemy with his shield, dealing {ShieldBash} damage while also taking a reduced {EnemyDamage} damage.");
        }
        
        else if (selection == "inventory")
        {
            
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
        
    if (currentEnemy.hp <= 0)
    {
        Console.WriteLine("");
        Console.WriteLine("Would you like to pillage the enemies body? [Yes / No]");
        string pillage = Console.ReadLine().ToLower();

            while (pillage != "no" && pillage != "yes")
            {
                Console.WriteLine("That's not an option");
                pillage = Console.ReadLine().ToLower();
            }

            if (pillage == "yes")

            {
                int Loot = Dice.Next(3);
                int NoobLoot = Dice.Next(grunt.loot.Length);
                Console.WriteLine($"You managed to dig up {currentEnemy.loot[Loot]}");
            }

            else if (pillage == "no")

            {
                Console.WriteLine("You decide to leave the poor soul to rest");
            }
            
            
            

        Console.WriteLine("Ready to face your next opponent?");
        string next = Console.ReadLine().ToLower();
        
        while (next != "yes" && next != "no")
        {
            Console.WriteLine("That's not an option.");
            next = Console.ReadLine().ToLower();
        }

        if (next == "yes")
        {
            currentEnemyNum++;
            Console.WriteLine($"Would you like to take a look at your inventory before facing {currentEnemy}? [Yes/No]");
            string inv = Console.ReadLine().ToLower();
            
            if (inv == "yes")
            {
                
            }

            else if (inv == "no")
            {
                
            }

        }

        else if (next == "no")
        {
            replay = false;
            Console.WriteLine("Okay, thank you for playing. Press any key to exit");
            Console.ReadKey();
        }
        
        
        currentEnemy = enemies[currentEnemyNum];



        Console.ReadLine();
    }
    
}




class Enemy 
{
    public string name;
    public int hp;
    public string[] loot;  
}

class Item
{
    public string itemName;
    public int itemDamage;
    public int itemHp;

} 