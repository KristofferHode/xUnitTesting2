using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Security.Cryptography.X509Certificates;

namespace MagicDeck;

class Program
{
    static void Main(string[] args)
    {
        Deck<MagicCard> deck = new Deck<MagicCard>();

        deck.Add(new MagicCard("Lightning Bolt", "Instant", 1 ));
        deck.Add(new MagicCard("Llanowar Elves", "Creature", 1 ));
        deck.Add(new MagicCard("Island", "Land", 0 ));
        deck.Add(new MagicCard("Counterspell", "Instant", 2 ));
        deck.Add(new MagicCard("Serra Angel", "Creature", 5));
        deck.Add(new MagicCard("Black Lotus", "Artifact", 0));
        deck.Add(new MagicCard("Shivan Dragon", "creature", 6));


        Console.WriteLine($"Deck contains {deck.Count} cards");
        Console.WriteLine("Before Shuffle:\n");
        deck.PrintAll();

        Console.WriteLine("\nPress any key to shuffle deck");
        Console.ReadKey();
        deck.Shuffle();

        Console.WriteLine("\nAfter shuffle:\n");
        deck.PrintAll();

        MagicCard drawn = deck.Draw();
        Console.WriteLine($"\nYou drew {drawn}");
        Console.WriteLine($"Cards left in the deck:{deck.Count}");

        Console.WriteLine($"\nPress any key to exit program...");
        Console.ReadKey();
    }
}
/*public static T Max<T>(T a, T b) where T : IComparable<T>
    {  //Unødvendig kode men vil beholde som ett eksempel for megselv
        Console.WriteLine("Hello, World!");

        Console.WriteLine(Max(32, 10));
        Console.WriteLine(Max("beta", "alpha"));
        return a.CompareTo(b) > 0 ? a : b;
    }*/