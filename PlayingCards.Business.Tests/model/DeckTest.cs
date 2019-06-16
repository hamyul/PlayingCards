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

        [TestMethod]
        public void should_shuffle_cards()
        {
            var sut = new Deck(null);
            IDeck originalDeck = new Deck(null);
            sut.Shuffle();

            Assert.AreNotEqual(sut, originalDeck);
        }

        [TestMethod]
        public void should_reset_cards()
        {
            var sut = new Deck(null);
            IDeck originalDeck = new Deck(null);
            sut.Shuffle();
            sut.Reset();

            Assert.AreEqual(sut, originalDeck);
        }
    }
}