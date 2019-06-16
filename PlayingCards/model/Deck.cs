using System;

namespace PlayingCards.model
{
    public class Deck : IDeck
    {
        private static Random random = new Random();
        private IPrintMethod _printMethod;
        public CardSuit[] Suits { get; private set; }

        public Deck(IPrintMethod printMethod)
        {
            _printMethod = printMethod;
            Reset();
        }

        public void Print()
        {
            foreach (var suit in Suits)
            {
                suit.Print();
            }
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
    }
}