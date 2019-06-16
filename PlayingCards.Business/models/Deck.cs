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
using PlayingCards.Business.enums;
using PlayingCards.Business.interfaces;

namespace PlayingCards.Business.models
{
    public class Deck : IDeck
    {
        private static Random random = new Random();
        private IPrintMethod _printMethod;
        public ICardSuit[] Suits { get; private set; }

        public Deck(IPrintMethod printMethod)
        {
            _printMethod = printMethod;
            Reset();
        }

        public bool Print()
        {
            foreach (var suit in Suits)
            {
                if (!suit.Print())
                    return false;
            }

            return true;
        }

        public void Shuffle()
        {
            foreach (var suit in Suits)
            {
                Shuffle(suit);
            }
        }

        protected void Shuffle(ICardSuit suit)
        {
            for (var i = suit.Cards.Count - 1; i > 0; i--)
            {
                var temp = suit.Cards[i];
                var index = random.Next(0, i + 1);
                suit.Cards[i] = suit.Cards[index];
                suit.Cards[index] = temp;
            }
        }

        public void Reset()
        {
            Suits = new CardSuit[4];
            Suits[0] = new CardSuit(SuitType.Clubs, _printMethod);
            Suits[1] = new CardSuit(SuitType.Diamonds, _printMethod);
            Suits[2] = new CardSuit(SuitType.Hearts, _printMethod);
            Suits[3] = new CardSuit(SuitType.Spade, _printMethod);
        }

        public override bool Equals(object obj)
        {
            var deck = obj as IDeck;
            for (int i = 0; i < Suits.Length; i++)
            {
                if (!Suits[i].Equals(deck.Suits[i]))
                    return false;
            }

            return true;
        }
    }
}