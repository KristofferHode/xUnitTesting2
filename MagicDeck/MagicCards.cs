using System.Reflection.Metadata.Ecma335;

namespace MagicDeck;
public class MagicCard
{
    public string Name { get; set; }
    public string Type { get; set; }
    public int Cost{ get; set; }

    public MagicCard(string name, string type, int cost)
    {
        Name = name;
        Type = type;
        Cost = cost;
    }
    public override string ToString()=> $"{Name} ({Type} {Cost} mana)";
}