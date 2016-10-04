namespace Cars.Models
{
    using Contracts;
    using System.Collections.Generic;

    public class Database : IDatabase
    {
        public IList<Car> Cars { get; set; }
    }
}
