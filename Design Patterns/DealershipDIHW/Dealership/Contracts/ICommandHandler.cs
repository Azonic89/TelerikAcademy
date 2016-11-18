namespace Dealership.Contracts
{
    using Engine;

    public interface ICommandHandler
    {
        void AddCommandHandler(ICommandHandler handler);

        string ProcessCommand(ICommand command, IEngine engine);
    }
}
