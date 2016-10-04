namespace TaskOne.Chef.Contracts
{
    public interface IVegetable
    {
        int Calories { get; }

        bool IsRotten { get; }

        bool IsPeeled { get; set; }

        bool IsCut { get; set; }

        bool IsCooked { get; set; }
    }
}
