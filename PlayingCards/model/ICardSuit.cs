using System.Collections.Generic;

namespace PlayingCards.model
{
    public interface ICardSuit
    {
        SuitType Type { get; }
        List<ICard> Cards { get; }
        void Print();
    }
}