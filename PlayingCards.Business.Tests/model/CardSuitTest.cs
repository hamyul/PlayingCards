using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlayingCards.Business.models;
using PlayingCards.Business.interfaces;
using PlayingCards.Business.enums;
using PlayingCards.Business.Tests.fakes;

namespace PlayingCards.Business.Tests.model
{
    [TestClass]
    public class CardSuitTest
    {
        [TestMethod]
        public void should_create_instance_when_constructor_is_called()
        {
            var sut = new CardSuit(SuitType.Diamonds, null);
            Assert.IsNotNull(sut);
        }

        [TestMethod]
        public void should_create_instance_of_cardsuit_type()
        {
            var sut = new CardSuit(SuitType.Diamonds, null);
            Assert.IsInstanceOfType(sut, typeof(ICardSuit));
        }

        [TestMethod]
        public void should_have_13_cards_after_create_instance()
        {
            var sut = new CardSuit(SuitType.Diamonds, null);
            Assert.IsTrue(sut.Cards.Count == 13);
        }

        [TestMethod]
        public void should_not_print_if_print_method_not_informed()
        {
            var sut = new CardSuit(SuitType.Clubs, null);
            var success = sut.Print();
            Assert.IsFalse(success);
        }

        [TestMethod]
        public void should_print_if_print_method_is_informed()
        {
            var printMethod = new FakePrintMethod();
            var sut = new CardSuit(SuitType.Clubs, printMethod);
            var success = sut.Print();
            Assert.IsTrue(success);
        }
    }
}