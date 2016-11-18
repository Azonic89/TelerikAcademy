namespace CompositeExample.Models
{
    using System;

    public class Hero : HeroComponent
    {
        public Hero(string name)
            : base(name)
        {
        }

        public override void Add(HeroComponent page)
        {
            Console.WriteLine("Cannot add to a person");
        }

        public override void Remove(HeroComponent page)
        {
            Console.WriteLine("Cannot remove from a person");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + this.name);
        }
    }
}
