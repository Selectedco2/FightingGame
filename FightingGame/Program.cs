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

using System.Diagnostics;

int YourHealth = 100;
int EnemyHealth = 100;

string You = "Karl Den Kristne";
string Enemy = "Average Non Believer";

Random generator = new Random();
int slumptal = generator.Next(1, 20);

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
        Console.WriteLine("You charge at the pleb with your holy blade");
        Console.WriteLine("You manage to deal " + slumptal + " damage to him.");
    }

    if (action == "B")
    {
        Console.WriteLine("You start trying to reason with him but he keeps trying to turn you into one of his kind");
        Console.WriteLine("The battle eventually begins");
    }
                
    // FIGHT

}



Console.ReadLine();