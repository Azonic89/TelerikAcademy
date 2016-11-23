namespace TaskOne.Chef.Models
{
    using System;

    using Contracts;

    public class Speach : ITalk
    {
        public void Say(string text)
        {
            Console.WriteLine(text);
        }
    }
}
