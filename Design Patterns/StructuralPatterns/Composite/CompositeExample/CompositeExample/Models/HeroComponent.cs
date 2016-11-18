namespace CompositeExample.Models
{
    public abstract class HeroComponent
    {
        protected string name;

        protected HeroComponent(string name)
        {
            this.name = name;
        }

        public abstract void Add(HeroComponent page);

        public abstract void Remove(HeroComponent page);

        public abstract void Display(int depth);
    }
}
