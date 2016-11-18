namespace Dealership.Engine.CommandHandlers
{
    using System.Linq;

    public class RemoveCommentCommandHandler : CommandHandler
    {
        protected override bool CanHandle(ICommand command)
        {
            return command.Name == "RemoveComment";
        }

        protected override string Handle(ICommand command, IEngine engine)
        {
            var vehicleIndex = int.Parse(command.Parameters[0]) - 1;
            var commentIndex = int.Parse(command.Parameters[1]) - 1;
            var username = command.Parameters[2];

            var user = engine.Users.FirstOrDefault(u => u.Username == username);

            if (user == null)
            {
                return string.Format($"There is no user with username {username}!");
            }

            this.ValidateRange(vehicleIndex, 0, user.Vehicles.Count, "The vehicle does not exist thus cannot be removed!");
            this.ValidateRange(commentIndex, 0, user.Vehicles[vehicleIndex].Comments.Count, "The comment does not exist thus cannot be removed!");

            var vehicle = user.Vehicles[vehicleIndex];
            var comment = user.Vehicles[vehicleIndex].Comments[commentIndex];

            engine.LoggedUser.RemoveComment(comment, vehicle);

            return string.Format($"{engine.LoggedUser.Username} removed comment successfully!");
        }
    }
}
