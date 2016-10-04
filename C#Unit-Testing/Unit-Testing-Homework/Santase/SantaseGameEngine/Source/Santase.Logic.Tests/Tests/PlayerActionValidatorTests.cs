namespace Santase.Logic.Tests
{
    using System.Collections.Generic;
    using Cards;
    using Players;
    using PlayerActionValidate;
    using RoundStates;

    using NUnit.Framework;

    [TestFixture]
    public class ExtendedPlayerActionValidatorTests
    {
        [Test]
        public void IsValid_ShouldReturnFalse_IfPassedANullValue()
        {
            var playerActionValidator = new PlayerActionValidator();

            var deck = new Deck();

            var stateManager = new StateManager();
            var context = new PlayerTurnContext(
                new StartRoundState(stateManager),
                deck.TrumpCard,
                deck.CardsLeft,
                30,
                30);

            var testPlayerHand = new List<Card>()
            {
                new Card(CardSuit.Club, CardType.Jack),
                new Card(CardSuit.Diamond, CardType.Nine)
            };

            var playerActionCard = new Card(CardSuit.Diamond, CardType.Jack);

            var actualOutcome = playerActionValidator.IsValid(
                null,
                context,
                testPlayerHand);

            Assert.IsFalse(actualOutcome);
        }

        [Test]
        public void IsValid_ShouldReturnTrue_IfPlayerActionIsPlayCardAndArgumentsAreCorrect()
        {
            var playerActionValidator = new PlayerActionValidator();

            var deck = new Deck();

            var stateManager = new StateManager();
            var context = new PlayerTurnContext(
                new MoreThanTwoCardsLeftRoundState(stateManager),
                deck.TrumpCard,
                deck.CardsLeft,
                30,
                30);

            var testPlayerHand = new List<Card>()
            {
                new Card(CardSuit.Club, CardType.Queen),
                new Card(CardSuit.Diamond, CardType.King),
                new Card(CardSuit.Club, CardType.King)
            };

            var playerActionCard = new Card(CardSuit.Club, CardType.King);

            var actualOutcome = playerActionValidator.IsValid(
                PlayerAction.PlayCard(playerActionCard),
                context,
                testPlayerHand);

            Assert.IsTrue(actualOutcome);
        }

        [Test]
        public void IsValid_ShouldReturnTrue_IfPlayerActionIsChangeTrumpAndArgumentsAreCorrect()
        {
            var playerActionValidator = new PlayerActionValidator();

            var deck = new Deck();

            var stateManager = new StateManager();
            var context = new PlayerTurnContext(
                new MoreThanTwoCardsLeftRoundState(stateManager),
                deck.TrumpCard,
                deck.CardsLeft,
                30,
                30);

            var testPlayerHand = new List<Card>()
            {
                new Card(CardSuit.Club, CardType.Queen),
                new Card(CardSuit.Diamond, CardType.King),
                new Card(CardSuit.Club, CardType.King),
                new Card(deck.TrumpCard.Suit, CardType.Nine)
            };

            var playerActionCard = new Card(CardSuit.Club, CardType.King);

            var actualOutcome = playerActionValidator.IsValid(
                PlayerAction.ChangeTrump(),
                context,
                testPlayerHand);

            Assert.IsTrue(actualOutcome);
        }
    }
}
