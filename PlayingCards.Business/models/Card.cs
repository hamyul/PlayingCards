using System;
using System.Collections.Generic;
using PlayingCards.Business.enums;
using PlayingCards.Business.interfaces;

namespace PlayingCards.Business.models
{
    public class Card : ICard
    {
        private List<string> _validationString = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "J", "D", "K" };
        public string CardValue { get; private set; }

        public SuitType Type { get; private set; }

        public Card(SuitType type, string cardValue)
        {
            Type = type;
            CardValue = ProcessCardValue(cardValue ?? string.Empty);
        }

        public Card(SuitType type, int cardValue)
            : this(type, cardValue.ToString())
        {
        }

        private void Validate(string cardValue)
        {
            if (string.IsNullOrEmpty(cardValue))
                throw new NullReferenceException("Card value cannot be null.");

            if (!_validationString.Contains(cardValue))
                throw new ArgumentException("Invalid card value.");
        }

        private string ProcessCardValue(string cardValue)
        {
            Validate(cardValue);

            switch (cardValue)
            {
                case "11":
                    return "J";
                case "12":
                    return "D";
                case "13":
                    return "K";
                default:
                    return cardValue;
            }
        }

        public override string ToString()
        {
            return $"{CardValue} of {Type}";
        }
    }
}