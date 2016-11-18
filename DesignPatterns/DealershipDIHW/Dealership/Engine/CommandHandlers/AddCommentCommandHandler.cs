namespace Dealership.Engine.CommandHandlers
{
    using System;
    using System.Linq;

    using Factories;

    public class AddCommentCommandHandler : CommandHandler
    {
        private readonly IDealershipFactory factory;

        public AddCommentCommandHandler(IDealershipFactory factory)
        {
            if (factory == null)
            {
                throw new ArgumentNullException(nameof(factory));
            }

            this.factory = factory;
        }

        protected override bool CanHandle(ICommand command)
        {
            return command.Name == "AddComment";
        }

        protected override string Handle(ICommand command, IEngine engine)
        {
            var content = command.Parameters[0];
            var author = command.Parameters[1];
            var vehicleIndex = int.Parse(command.Parameters[2]) - 1;

            var comment = this.factory.CreateComment(content);
            comment.Author = engine.LoggedUser.Username;
            var user = engine.Users.FirstOrDefault(u => u.Username == author);

            if (user == null)
            {
                return string.Format($"There is no user with username {author}!");
            }

            this.ValidateRange(vehicleIndex, 0, user.Vehicles.Count, "The vehicle does not exist!");

            var vehicle = user.Vehicles[vehicleIndex];

            engine.LoggedUser.AddComment(comment, vehicle);

            return string.Format($"{engine.LoggedUser.Username} added comment successfully!");
        }
    }
}
