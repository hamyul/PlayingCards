using System.Collections.Generic;

namespace PlayingCards.Business.model
{
    public interface ICardSuit
    {
        SuitType Type { get; }
        List<ICard> Cards { get; }
        void Print();
    }
}