namespace PlayingCards.model
{
    public interface ICard
    {
        string CardValue { get; }
        DeckType Type { get; }
    }
}