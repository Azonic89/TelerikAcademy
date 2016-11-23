namespace TaskOne.Chef.Models.Vegetables
{
    using Constants;
    using Contracts;

    public class Carrot : Vegetable, IVegetable
    {
        public Carrot() : base()
        {
            this.Calories = Constants.CarrortCalories;
        }
    }
}
