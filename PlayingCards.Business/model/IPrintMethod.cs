namespace PlayingCards.Business.model
{
    public interface IPrintMethod
    {
        void Print(ICardSuit deck);
    }
}