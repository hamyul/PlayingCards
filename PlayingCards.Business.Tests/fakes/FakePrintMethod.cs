using System;
using PlayingCards.Business.interfaces;

namespace PlayingCards.Business.Tests.fakes
{
    internal class FakePrintMethod : IPrintMethod
    {
        public void Print(ICardSuit cardSuit)
        {
            // do nothing...
        }
    }
}