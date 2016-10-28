namespace DecoratorExample.Models
{
    public abstract class Decorator : BorrowableItem
    {
        protected Decorator(BorrowableItem item)
        {
            this.Item = item;
        }

        protected BorrowableItem Item { get; set; }

        public override void Display()
        {
            this.Item.Display();
        }
    }
}
