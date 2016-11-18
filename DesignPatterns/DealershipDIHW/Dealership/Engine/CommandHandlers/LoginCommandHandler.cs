namespace Dealership.Engine.CommandHandlers
{
    using System.Linq;

    public class LoginCommandHandler : CommandHandler
    {
        protected override bool CanHandle(ICommand command)
        {
            return command.Name == "Login";
        }

        protected override string Handle(ICommand command, IEngine engine)
        {
            var username = command.Parameters[0];
            var password = command.Parameters[1];

            if (engine.LoggedUser != null)
            {
                return string.Format($"User {engine.LoggedUser.Username} is logged in! Please log out first!");
            }

            var userFound = engine.Users.FirstOrDefault(u => u.Username.ToLower() == username.ToLower());

            if (userFound != null && userFound.Password == password)
            {
                engine.SetLoggedUser(userFound);
                return string.Format($"User {username} successfully logged in!");
            }

            return "Wrong username or password!";
        }
    }
}
