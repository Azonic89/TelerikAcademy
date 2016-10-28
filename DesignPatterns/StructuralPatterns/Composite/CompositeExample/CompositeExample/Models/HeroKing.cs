namespace CompositeExample.Models
{
    using System;
    using System.Collections.Generic;

    public class HeroKing : HeroComponent
    {
        private ICollection<HeroComponent> subjects;

        public HeroKing(string name)
            : base(name)
        {
            this.subjects = new List<HeroComponent>();
        }

        public override void Add(HeroComponent person)
        {
            this.subjects.Add(person);
        }

        public override void Remove(HeroComponent person)
        {
            this.subjects.Remove(person);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('_', depth) + this.name);

            foreach (var person in this.subjects)
            {
                person.Display(depth + 2);
            }
        }
    }
}
