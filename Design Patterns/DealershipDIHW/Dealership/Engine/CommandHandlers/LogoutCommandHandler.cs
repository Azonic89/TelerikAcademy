namespace Dealership.Engine.CommandHandlers
{
    public class LogoutCommandHandler : CommandHandler
    {
        protected override bool CanHandle(ICommand command)
        {
            return command.Name == "Logout";
        }

        protected override string Handle(ICommand command, IEngine engine)
        {
            engine.SetLoggedUser(null);
            return "You successfully logget out!";
        }
    }
}
