/*
MIT License

Copyright (c) 2018 Hammond Soares

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

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