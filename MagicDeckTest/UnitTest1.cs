namespace MagicDeck.tests;

public class UnitTest1
{
    [Fact]
    public void Add_AddsCardToDeck()
    {
        var deck = new Deck<MagicCard>();
        var card = new MagicCard("Ligthningbolt", "Instant", 1);
    }

    [Fact]
    public void Draw_CardFromDeck()
    {
        
    }

}