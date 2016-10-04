namespace Poker.Tests
{
    using System;
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class HandTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Hand_ShouldThrowArgumentNullException_WhenNullHandsAreAddedToTheList()
        {
            IList<ICard> cards = null;
            var hand = new Hand(cards);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Hand_ShouldThrowArgumentNullException_WhenListOfCardsContainsNull()
        {
            IList<ICard> cards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                null
            };

            var hand = new Hand(cards);
        }

        [TestMethod]
        public void Hand_ShouldReturnCorrectString_WhenUsingOverrideToStringMethod()
        {
            IList<ICard> cards = new List<ICard>()
            {
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Spades)
            };

            var hand = new Hand(cards);

            var expected = "Four of Clubs - Queen of Spades";

            Assert.AreEqual(expected, hand.ToString());
        }
    }
}
