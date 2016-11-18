namespace Dealership.Engine.CommandHandlers
{
    using System;

    using Contracts;

    public abstract class CommandHandler : ICommandHandler
    {
        private ICommandHandler handler;

        public void AddCommandHandler(ICommandHandler handler)
        {
            this.handler = handler;
        }

        public string ProcessCommand(ICommand command, IEngine engine)
        {
            string result;
            if (this.CanHandle(command))
            {
                result = this.Handle(command, engine);
            }
            else if (this.handler != null)
            {
                result = this.handler.ProcessCommand(command, engine);
            }
            else
            {
                result = $"Invalid Command - {command.Name}";
            }

            return result;
        }

        protected void ValidateRange(int? value, int min, int max, string message)
        {
            if (value < min || value >= max)
            {
                throw new ArgumentException(message);
            }
        }

        protected abstract bool CanHandle(ICommand command);

        protected abstract string Handle(ICommand command, IEngine engine);
    }
}
