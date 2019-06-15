namespace PlayingCards.model
{
    public class Card : ICard
    {
        public string CardValue { get; private set; }

        public DeckType Type { get; private set; }

        public Card(DeckType type, string cardValue)
        {
            Type = type;
            CardValue = ProcessCardValue(cardValue);
        }

        public Card(DeckType type, int cardValue)
            : this(type, cardValue.ToString())
        {
        }

        private string ProcessCardValue(string cardValue)
        {
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
    }
}