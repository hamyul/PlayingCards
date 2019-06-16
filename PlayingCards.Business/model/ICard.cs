namespace PlayingCards.Business.model
{
    public interface ICard
    {
        string CardValue { get; }
        SuitType Type { get; }
    }
}