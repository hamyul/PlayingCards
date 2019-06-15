using System;
using System.Collections.Generic;

namespace PlayingCards.model
{
    public class CardDeck : ICardDeck
    {
        public DeckType Type { get; private set; }
        public List<ICard> Cards { get; private set; }
        private IPrintMethod _printMethod;

        public CardDeck(DeckType type, IPrintMethod printMethod)
        {
            Type = type;
            _printMethod = printMethod;
        }

        public void GenerateCards()
        {
            for (int i = 1; i <= 13; i++)
            {
                Cards.Add(new Card(Type, i));
            }
        }

        public void Print()
        {
            if (_printMethod == null)
                return;

            _printMethod.Print(this);
        }
    }
}