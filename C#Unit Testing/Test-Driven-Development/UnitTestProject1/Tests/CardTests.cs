namespace Poker.Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void Card_ShouldCompareCardsCorreclty_WhenEqualCardsArePassed()
        {
            var cardOne = new Card(CardFace.Ace, CardSuit.Diamonds);
            var cardTwo = new Card(CardFace.Ace, CardSuit.Diamonds);

            Assert.IsTrue(cardOne.Equals(cardTwo));
        }

        [TestMethod]
        public void Card_ShouldCompareCardsCorreclty_WhenDifferentCardsArePassed()
        {
            var cardOne = new Card(CardFace.Eight, CardSuit.Clubs);
            var cardTwo = new Card(CardFace.Four, CardSuit.Diamonds);

            Assert.IsFalse(cardOne.Equals(cardTwo));
        }

        [TestMethod]
        public void Card_ShouldReturnCorrectString_WhenUsingOverrideToStringMethod()
        {
            var card = new Card(CardFace.King, CardSuit.Hearts);

            var expected = "King of Hearts";

            Assert.AreEqual(expected, card.ToString());
        }
    }
}
