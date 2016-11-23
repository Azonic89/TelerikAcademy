namespace Poker
{
    using System;
    using System.Collections.Generic;

    public class Hand : IHand
    {
        public Hand(IList<ICard> cards)
        {
            if (cards == null)
            {
                throw new ArgumentNullException("The List of Cards cannot be null");
            }

            foreach (var card in cards)
            {
                if (card == null)
                {
                    throw new ArgumentNullException("Card Cannot be null");
                }
            }

            this.Cards = cards;
        }

        public IList<ICard> Cards { get; private set; }

        public override string ToString()
        {
            return string.Join(" - ", this.Cards);
        }
    }
}
