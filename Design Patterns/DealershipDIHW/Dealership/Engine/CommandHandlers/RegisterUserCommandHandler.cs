namespace Dealership.Engine.CommandHandlers
{
    using System;
    using System.Linq;

    using Common.Enums;
    using Factories;

    public class RegisterUserCommandHandler : CommandHandler
    {
        private readonly IDealershipFactory factory;

        public RegisterUserCommandHandler(IDealershipFactory factory)
        {
            if (factory == null)
            {
                throw new ArgumentNullException(nameof(factory));
            }

            this.factory = factory;
        }

        protected override bool CanHandle(ICommand command)
        {
            return command.Name == "RegisterUser";
        }

        protected override string Handle(ICommand command, IEngine engine)
        {
            var username = command.Parameters[0];
            var firstName = command.Parameters[1];
            var lastName = command.Parameters[2];
            var password = command.Parameters[3];

            var role = Role.Normal;

            if (command.Parameters.Count > 4)
            {
                role = (Role)Enum.Parse(typeof(Role), command.Parameters[4]);
            }

            if (engine.LoggedUser != null)
            {
                return string.Format($"User {engine.LoggedUser.Username} is logged in! Please log out first!");
            }

            if (engine.Users.Any(u => u.Username.ToLower() == username.ToLower()))
            {
                return string.Format($"User {username} already exist. Choose a different username!");
            }

            var user = this.factory.CreateUser(username, firstName, lastName, password, role.ToString());
            engine.SetLoggedUser(user);
            engine.Users.Add(user);

            return string.Format($"User {username} registered successfully!");
        }
    }
}
