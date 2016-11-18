namespace Dealership.Engine.CommandHandlers
{
    using System.Linq;

    public class ShowVehiclesCommandHandler : CommandHandler
    {
        protected override bool CanHandle(ICommand command)
        {
            return command.Name == "ShowVehicles";
        }

        protected override string Handle(ICommand command, IEngine engine)
        {
            var username = command.Parameters[0];

            var user = engine.Users.FirstOrDefault(u => u.Username.ToLower() == username.ToLower());

            if (user == null)
            {
                return string.Format($"There is no user with username {username}!");
            }

            return user.PrintVehicles();
        }
    }
}
