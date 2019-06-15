using System;
using PlayingCards.model;

namespace PlayingCards
{
    class Program
    {
        static void Main(string[] args)
        {
            var outputMethod = new PrintConsoleMethod();

            var heartsCardDeck = GetCardDeck(DeckType.Hearts, outputMethod);
            var clubsCardDeck = GetCardDeck(DeckType.Clubs, outputMethod);
            var spadeCardDeck = GetCardDeck(DeckType.Spade, outputMethod);
            var diamondsCardDeck = GetCardDeck(DeckType.Diamonds, outputMethod);

            heartsCardDeck.Print();
            clubsCardDeck.Print();
            spadeCardDeck.Print();
            diamondsCardDeck.Print();
        }

        public static ICardDeck GetCardDeck(DeckType type, IPrintMethod printMethod)
        {
            ICardDeck cardDeck = new CardDeck(type, printMethod);
            cardDeck.GenerateCards();

            return cardDeck;
        }
    }
}
