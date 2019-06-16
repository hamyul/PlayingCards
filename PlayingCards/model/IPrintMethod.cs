namespace PlayingCards.model
{
    public interface IPrintMethod
    {
        void Print(ICardSuit deck);
    }
}