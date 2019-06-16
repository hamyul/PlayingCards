using System;
using PlayingCards.model;

namespace PlayingCards
{
    class Program
    {
        static void Main(string[] args)
        {
            var outputMethod = new PrintConsoleMethod();

            var heartsCardDeck = new CardSuit(SuitType.Hearts, outputMethod);
            var clubsCardDeck = new CardSuit(SuitType.Clubs, outputMethod);
            var spadeCardDeck = new CardSuit(SuitType.Spade, outputMethod);
            var diamondsCardDeck = new CardSuit(SuitType.Diamonds, outputMethod);

            heartsCardDeck.Print();
            clubsCardDeck.Print();
            spadeCardDeck.Print();
            diamondsCardDeck.Print();
        }
    }
}
