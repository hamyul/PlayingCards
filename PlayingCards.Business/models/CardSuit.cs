using System;
using System.Collections.Generic;
using PlayingCards.Business.enums;
using PlayingCards.Business.interfaces;

namespace PlayingCards.Business.models
{
    public class CardSuit : ICardSuit
    {
        public SuitType Type { get; private set; }
        public List<ICard> Cards { get; private set; }
        private IPrintMethod _printMethod;

        public CardSuit(SuitType type, IPrintMethod printMethod)
        {
            Type = type;
            Cards = new List<ICard>();
            _printMethod = printMethod;

            GenerateCards();
        }

        protected void GenerateCards()
        {
            for (int i = 1; i <= 13; i++)
            {
                Cards.Add(new Card(Type, i));
            }
        }

        public bool Print()
        {
            if (_printMethod == null)
                return false;

            _printMethod.Print(this);
            return true;
        }
    }
}