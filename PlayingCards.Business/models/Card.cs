/*
MIT License

Copyright (c) 2018 Hammond Soares

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

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

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            var card = obj as ICard;

            return (card.CardValue == CardValue && card.Type == Type);
        }
    }
}