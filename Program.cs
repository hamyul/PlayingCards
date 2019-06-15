using System;
using PlayingCards.model;

namespace PlayingCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var heartsCardDeck = new CardDeck(DeckType.Hearts, new PrintConsoleMethod());
            var clubsCardDeck = new CardDeck(DeckType.Clubs, new PrintConsoleMethod());
            var spadeCardDeck = new CardDeck(DeckType.Spade, new PrintConsoleMethod());
            var diamondsCardDeck = new CardDeck(DeckType.Diamonds, new PrintConsoleMethod());

            heartsCardDeck.Print();
            clubsCardDeck.Print();
            spadeCardDeck.Print();
            diamondsCardDeck.Print();
        }
    }
}
