using System;
using PlayingCards.model;

namespace PlayingCards
{
    class Program
    {
        static void Main(string[] args)
        {
            var outputMethod = new PrintConsoleMethod();

            var heartsCardDeck = new CardDeck(DeckType.Hearts, outputMethod);
            var clubsCardDeck = new CardDeck(DeckType.Clubs, outputMethod);
            var spadeCardDeck = new CardDeck(DeckType.Spade, outputMethod);
            var diamondsCardDeck = new CardDeck(DeckType.Diamonds, outputMethod);

            heartsCardDeck.Print();
            clubsCardDeck.Print();
            spadeCardDeck.Print();
            diamondsCardDeck.Print();
        }
    }
}
