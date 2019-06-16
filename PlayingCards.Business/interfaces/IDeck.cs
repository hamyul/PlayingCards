namespace PlayingCards.Business.interfaces
{
    public interface IDeck
    {
        ICardSuit[] Suits { get; }
        void Print();
        void Shuffle();
        void Reset();
    }
}