namespace TaskOne.Chef.Contracts
{
    using Models;
    using Models.Vegetables;

    public interface IChef
    {
        Bowl GetBowl();

        Carrot GetCarrot();

        Potato GetPotato();

        void Cut(IVegetable vegetable);

        void Peel(IVegetable vegetable);
    }
}
