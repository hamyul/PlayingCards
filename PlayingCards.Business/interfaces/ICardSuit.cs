using System.Collections.Generic;
using PlayingCards.Business.enums;

namespace PlayingCards.Business.interfaces
{
    public interface ICardSuit
    {
        SuitType Type { get; }
        List<ICard> Cards { get; }
        bool Print();
    }
}