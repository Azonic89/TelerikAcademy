namespace TaskOne.Chef.Contracts
{
    using System.Collections.Generic;

    public interface IContainable
    {
        IList<IVegetable> Contents { get; }
    }
}
