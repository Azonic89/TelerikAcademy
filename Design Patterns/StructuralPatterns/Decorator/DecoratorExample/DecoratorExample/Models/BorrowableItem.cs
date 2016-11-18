namespace DecoratorExample.Models
{
    public abstract class BorrowableItem
    {
        public int CopiesCount { get; set; }

        public abstract void Display();
    }
}
