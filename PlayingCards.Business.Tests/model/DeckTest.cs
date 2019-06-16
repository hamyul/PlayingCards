using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlayingCards.Business.models;
using PlayingCards.Business.interfaces;
using PlayingCards.Business.enums;
using PlayingCards.Business.Tests.fakes;

namespace PlayingCards.Business.Tests.model
{
    [TestClass]
    public class DeckTest
    {
        [TestMethod]
        public void should_create_instance_when_constructor_is_called()
        {
            var sut = new Deck(null);
            Assert.IsNotNull(sut);
        }

        [TestMethod]
        public void should_create_instance_of_type_ideck()
        {
            var sut = new Deck(null);
            Assert.IsInstanceOfType(sut, typeof(IDeck));
        }

        [TestMethod]
        public void should_have_4_suits_after_create_instance()
        {
            var sut = new Deck(null);
            Assert.IsTrue(sut.Suits.Length == 4);
        }

        [TestMethod]
        public void should_not_print_if_print_method_not_informed()
        {
            var sut = new Deck(null);
            var success = sut.Print();
            Assert.IsFalse(success);
        }

        [TestMethod]
        public void should_print_if_print_method_is_informed()
        {
            var printMethod = new FakePrintMethod();
            var sut = new Deck(printMethod);
            var success = sut.Print();
            Assert.IsTrue(success);
        }

        // TODO: Crete tests for methods Shuffle and Reset.
    }
}