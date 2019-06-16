using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlayingCards.Business.model;

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

        // [TestMethod]
        // public void should_fail()
        // {
        //     ICard sut = new Card(SuitType.Clubs, "2");
        //     Assert.Fail();
        // }
    }
}
