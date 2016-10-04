namespace TaskOne.Chef.Models.Vegetables
{
    using Contracts;

    public class Vegetable : IVegetable
    {
        public Vegetable()
        {
            this.IsRotten = false;
            this.IsPeeled = false;
            this.IsCut = false;
            this.IsCooked = false;
        }

        public int Calories { get; protected set; }

        public bool IsRotten { get; set; }

        public bool IsPeeled { get; set; }

        public bool IsCut { get; set; }

        public bool IsCooked { get; set; }
    }
}
