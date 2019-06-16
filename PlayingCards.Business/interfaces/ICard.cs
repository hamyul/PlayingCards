using PlayingCards.Business.enums;

namespace PlayingCards.Business.interfaces
{
    public interface ICard
    {
        string CardValue { get; }
        SuitType Type { get; }
    }
}