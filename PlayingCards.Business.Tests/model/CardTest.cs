using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlayingCards.Business.models;
using PlayingCards.Business.interfaces;
using PlayingCards.Business.enums;

namespace PlayingCards.Business.Tests.model
{
    [TestClass]
    public class CardTest
    {
        [TestMethod]
        public void should_create_instance_when_constructor_called()
        {

            ICard sut = new Card(SuitType.Clubs, "2");
            Assert.IsNotNull(sut);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void should_throw_exception_when_passing_empty_string_to_constructor()
        {
            ICard sut = new Card(SuitType.Clubs, string.Empty);
            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void should_throw_exception_when_passing_null_string_to_constructor()
        {
            ICard sut = new Card(SuitType.Clubs, null);
            Assert.Fail();
        }

        [TestMethod]
        public void should_create_instance_when_passing_integer_to_constructor()
        {
            ICard sut = new Card(SuitType.Clubs, 1);
            Assert.IsNotNull(sut);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void should_throw_exception_when_passing_integer_equal_or_less_than_0_to_constructor()
        {
            ICard sut = new Card(SuitType.Clubs, 0);
            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void should_throw_exception_when_passing_integer_higher_then_13_to_constructor()
        {
            ICard sut = new Card(SuitType.Clubs, 14);
            Assert.Fail();
        }

        [TestMethod]
        public void should_return_J_when_process_card_value_11()
        {
            var sut = new Card(SuitType.Hearts, "11");
            Assert.IsTrue(sut.CardValue == "J");
        }


        [TestMethod]
        public void should_return_D_when_process_card_value_12()
        {
            var sut = new Card(SuitType.Hearts, "12");
            Assert.IsTrue(sut.CardValue == "D");
        }

        [TestMethod]
        public void should_return_K_when_process_card_value_13()
        {
            var sut = new Card(SuitType.Hearts, "13");
            Assert.IsTrue(sut.CardValue == "K");
        }

        [TestMethod]
        public void should_return_value_when_process_card_value_is_10()
        {
            var sut = new Card(SuitType.Hearts, "10");
            Assert.IsTrue(sut.CardValue == "10");
        }

        [TestMethod]
        public void should_return_value_when_process_card_value_is_9()
        {
            var sut = new Card(SuitType.Hearts, "9");
            Assert.IsTrue(sut.CardValue == "9");
        }

        [TestMethod]
        public void should_return_value_when_process_card_value_is_8()
        {
            var sut = new Card(SuitType.Hearts, "8");
            Assert.IsTrue(sut.CardValue == "8");
        }

        [TestMethod]
        public void should_return_value_when_process_card_value_is_7()
        {
            var sut = new Card(SuitType.Hearts, "7");
            Assert.IsTrue(sut.CardValue == "7");
        }

        [TestMethod]
        public void should_return_value_when_process_card_value_is_6()
        {
            var sut = new Card(SuitType.Hearts, "6");
            Assert.IsTrue(sut.CardValue == "6");
        }

        [TestMethod]
        public void should_return_value_when_process_card_value_is_5()
        {
            var sut = new Card(SuitType.Hearts, "5");
            Assert.IsTrue(sut.CardValue == "5");
        }

        [TestMethod]
        public void should_return_value_when_process_card_value_is_4()
        {
            var sut = new Card(SuitType.Hearts, "4");
            Assert.IsTrue(sut.CardValue == "4");
        }

        [TestMethod]
        public void should_return_value_when_process_card_value_is_3()
        {
            var sut = new Card(SuitType.Hearts, "3");
            Assert.IsTrue(sut.CardValue == "3");
        }

        [TestMethod]
        public void should_return_value_when_process_card_value_is_2()
        {
            var sut = new Card(SuitType.Hearts, "2");
            Assert.IsTrue(sut.CardValue == "2");
        }

        [TestMethod]
        public void should_return_value_when_process_card_value_is_1()
        {
            var sut = new Card(SuitType.Hearts, "1");
            Assert.IsTrue(sut.CardValue == "1");
        }
    }
}
