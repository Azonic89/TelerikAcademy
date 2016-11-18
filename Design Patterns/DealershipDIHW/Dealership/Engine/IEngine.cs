namespace Dealership.Engine
{
    using System.Collections.Generic;

    using Contracts;

    public interface IEngine
    {
        ICollection<IUser> Users { get; }

        IUser LoggedUser { get; }

        void SetLoggedUser(IUser user);

        void Start();

        void Reset();
    }
}
