namespace TaskOne.Chef.Models.Vegetables
{
    using Constants;
    using Contracts;

    public class Potato : Vegetable, IVegetable
    {
        public Potato() : base()
        {
            this.Calories = Constants.PotatoCalories;
        }
    }
}
