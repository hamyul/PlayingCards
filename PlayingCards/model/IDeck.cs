namespace PlayingCards.model
{
    public interface IDeck
    {
        CardSuit[] Suits { get; }
        void Print();
        void Shuffle();
        void Reset();
    }
}