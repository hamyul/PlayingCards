using System;

namespace PlayingCards.model
{
    public class PrintConsoleMethod : IPrintMethod
    {
        public void Print(ICardDeck deck)
        {
            foreach (var card in deck.Cards)
            {
                Console.WriteLine($"{card.CardValue} of {card.Type}");
            }
        }
    }
}