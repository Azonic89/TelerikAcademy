namespace DecoratorExample.Models
{
    using System;
    using System.Collections.Generic;

    public class Borrowable : Decorator
    {
        private readonly List<string> borrowers = new List<string>();

        public Borrowable(BorrowableItem item)
            : base(item)
        {
        }

        public void BorrowItem(string name)
        {
            this.borrowers.Add(name);
            this.Item.CopiesCount--;
        }

        public void ReturnItem(string name)
        {
            this.borrowers.Remove(name);
            this.Item.CopiesCount++;
        }

        public override void Display()
        {
            base.Display();

            foreach (var borrower in this.borrowers)
            {
                Console.WriteLine(" borrower: " + borrower);
            }
        }
    }
}
