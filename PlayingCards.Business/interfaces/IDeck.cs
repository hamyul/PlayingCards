namespace PlayingCards.Business.interfaces
{
    public interface IDeck
    {
        ICardSuit[] Suits { get; }
        bool Print();
        void Shuffle();
        void Reset();
    }
}