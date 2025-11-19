using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
namespace MagicDeck;
public class Deck<T>
{
    private List<T> cards = new List<T>();
    private Random random = new Random();
    public void Add(T card)
    {
        cards.Add(card);
    }
    public void Remove(T card)
    {
        cards.Remove(card);
    }
    public T GetCard(int index)
    {
        if (index < 0 || index >= cards.Count)
            throw new IndexOutOfRangeException("Index error");
        return cards[index];
    }
    public void PrintAll()
    {
        foreach (var card in cards)
        {
            Console.WriteLine(card);
        }
    }
    public void Shuffle()
    {
        Span<T> span = CollectionsMarshal.AsSpan(cards);

        Random.Shared.Shuffle(span);
        Console.WriteLine("Deck is shuffle..");
    }
    
    public T Draw()
    {
        if (cards.Count == 0)
        {
            throw new InvalidOperationException("Cant draw cards from an empty deck");
        }
        T topCard = cards[0];
        cards.RemoveAt(0);
        return topCard;
    }
    public int Count => cards.Count;
    public void Clear()
    {
        cards.Clear();
    }

}