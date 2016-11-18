namespace Dealership.Engine.CommandHandlers
{
    using System.Text;

    using Common.Enums;

    public class ShowUsersCommandHandler : CommandHandler
    {
        protected override bool CanHandle(ICommand command)
        {
            return command.Name == "ShowUsers";
        }

        protected override string Handle(ICommand command, IEngine engine)
        {
            if (engine.LoggedUser.Role != Role.Admin)
            {
                return "You are not an admin!";
            }

            var builder = new StringBuilder();
            builder.AppendLine("--USERS--");
            var counter = 1;
            foreach (var user in engine.Users)
            {
                builder.AppendLine(string.Format($"{counter}. {user}"));
                counter++;
            }

            return builder.ToString().Trim();
        }
    }
}
