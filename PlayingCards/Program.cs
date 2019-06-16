using System;
using PlayingCards.model;

namespace PlayingCards
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrintMethod outputMethod = new PrintConsoleMethod();
            IDeck deck = new Deck(outputMethod);

            PrintDivision("1st print after deck creation.");
            deck.Print();

            PrintDivision("2nd print after deck shuffle.");
            deck.Shuffle();
            deck.Print();

            PrintDivision("3rd print after deck reset.");
            deck.Reset();
            deck.Print();
        }

        static void PrintDivision(string text)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Gray;

        }
    }
}
