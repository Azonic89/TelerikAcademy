namespace RangeExceptions
{
    using System;

    public class InvalidRangeException<T> : ApplicationException
    {
        private T start;
        private T end;

        public InvalidRangeException(string message, T start, T end, Exception causeException)
            : base(message, causeException)
        {
            this.Start = start;
            this.End = end;       
        }

        public InvalidRangeException(string message, T start, T end)
            : this(message, start, end, null)
        {

        }

        public T Start
        {
            get { return this.start; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Start Range cannot be a null value");
                }
                else
                {
                    this.start = value;
                }
            }
        }

        public T End
        {
            get { return this.end; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("End Range cannot be a null value");
                }
                else
                {
                    this.end = value;
                }
            }
        }
    }
}
