using System.Collections.Generic;

namespace PlayingCards.model
{
    public interface ICardDeck
    {
        DeckType Type { get; }
        List<ICard> Cards { get; }
        void Print();
    }
}