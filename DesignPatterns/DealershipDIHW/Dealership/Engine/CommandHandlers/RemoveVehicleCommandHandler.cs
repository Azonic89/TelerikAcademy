namespace Dealership.Engine.CommandHandlers
{
    public class RemoveVehicleCommandHandler : CommandHandler
    {
        protected override bool CanHandle(ICommand command)
        {
            return command.Name == "RemoveVehicle";
        }

        protected override string Handle(ICommand command, IEngine engine)
        {
            var vehicleIndex = int.Parse(command.Parameters[0]) - 1;

            this.ValidateRange(vehicleIndex, 0, engine.LoggedUser.Vehicles.Count, "The vehicle does not exist thus cannot be removed!");

            var vehicle = engine.LoggedUser.Vehicles[vehicleIndex];

            engine.LoggedUser.RemoveVehicle(vehicle);

            return string.Format($"{engine.LoggedUser.Username} removed vehicle successfully!");
        }
    }
}
