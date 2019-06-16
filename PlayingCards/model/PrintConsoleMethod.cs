using System;

namespace PlayingCards.model
{
    public class PrintConsoleMethod : IPrintMethod
    {
        public void Print(ICardSuit deck)
        {
            if (deck == null)
                throw new NullReferenceException("The deck informed to print is null.");

            if (deck.Cards == null)
                throw new NullReferenceException("No cards available to print.");

            foreach (var card in deck.Cards)
            {
                Console.WriteLine($"{card.CardValue} of {card.Type}");
            }

            Console.WriteLine();
        }
    }
}