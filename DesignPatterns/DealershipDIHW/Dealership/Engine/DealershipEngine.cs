namespace Dealership.Engine
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Contracts;
    using Factories;

    public sealed class DealershipEngine : IEngine
    {
        private const string UserNotLogged = "You are not logged! Please login first!";

        private readonly IDealershipFactory factory;
        private readonly ILoggingProvider loggingProvider;
        private readonly ICommandHandler commandHandler;
        private ICollection<IUser> users;
        private IUser loggedUser;

        public DealershipEngine(
            IDealershipFactory factory,
            ILoggingProvider loggingProvider,
            ICommandHandler commandHandler)
        {
            if (factory == null)
            {
                throw new ArgumentNullException(nameof(factory));
            }

            if (loggingProvider == null)
            {
                throw new ArgumentNullException(nameof(loggingProvider));
            }

            if (commandHandler == null)
            {
                throw new ArgumentNullException(nameof(commandHandler));
            }

            this.factory = factory;
            this.loggingProvider = loggingProvider;
            this.commandHandler = commandHandler;

            this.users = new HashSet<IUser>();
            this.loggedUser = null;
        }

        public ICollection<IUser> Users
        {
            get { return this.users; }
        }

        public IUser LoggedUser
        {
            get { return this.loggedUser; }
        }

        public void SetLoggedUser(IUser user)
        {
            this.loggedUser = user;
        }

        public void Start()
        {
            var commands = this.ReadCommands();
            var commandResult = this.ProcessCommands(commands);
            this.PrintReports(commandResult);
        }

        public void Reset()
        {
            this.users = new List<IUser>();
            this.loggedUser = null;
            var commands = new List<ICommand>();
            var commandResult = new List<string>();
            this.PrintReports(commandResult);
        }

        private IList<ICommand> ReadCommands()
        {
            var commands = new List<ICommand>();

            var currentLine = this.loggingProvider.Read();

            while (!string.IsNullOrEmpty(currentLine))
            {
                var currentCommand = this.factory.CreateCommand(currentLine);
                commands.Add(currentCommand);

                currentLine = this.loggingProvider.Read();
            }

            return commands;
        }

        private IList<string> ProcessCommands(IList<ICommand> commands)
        {
            var reports = new List<string>();

            foreach (var command in commands)
            {
                try
                {
                    var report = this.ProcessSingleCommand(command);
                    reports.Add(report);
                }
                catch (Exception ex)
                {
                    reports.Add(ex.Message);
                }
            }

            return reports;
        }

        private void PrintReports(IList<string> reports)
        {
            var output = new StringBuilder();

            foreach (var report in reports)
            {
                output.AppendLine(report);
                output.AppendLine(new string('#', 20));
            }

           this.loggingProvider.Write(output.ToString());
        }

        private string ProcessSingleCommand(ICommand command)
        {
            if (command.Name != "RegisterUser" && command.Name != "Login")
            {
                if (this.loggedUser == null)
                {
                    return UserNotLogged;
                }
            }

            return this.commandHandler.ProcessCommand(command, this);
        }
    }
}
