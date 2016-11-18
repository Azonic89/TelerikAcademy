namespace Dealership.NinjectConfig
{
    using System;

    using Contracts;
    using Engine;
    using Engine.CommandHandlers;
    using Factories;
    using Models;

    using Ninject;
    using Ninject.Extensions.Conventions;
    using Ninject.Extensions.Factory;
    using Ninject.Modules;

    public class DealershipBindings : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind(x => x.FromThisAssembly()
                .SelectAllClasses()
                .BindDefaultInterface());

            this.Bind<Func<string>>().ToMethod(ctx => () => Console.ReadLine());

            this.Bind<Action<string>>().ToMethod(ctx => (param) =>
            {
                Console.Write(param);
            });

            this.Bind<IVehicle>().To<Car>().Named("Car");
            this.Bind<IVehicle>().To<Motorcycle>().Named("Motorcycle");
            this.Bind<IVehicle>().To<Truck>().Named("Truck");
            this.Bind<IDealershipFactory>().ToFactory().InSingletonScope();

            this.Bind<ICommandHandler>().To<LoginCommandHandler>().Named("LoginCommandHandler");
            this.Bind<ICommandHandler>().To<RegisterUserCommandHandler>().Named("RegisterUserCommandHandler");            
            this.Bind<ICommandHandler>().To<LogoutCommandHandler>().Named("LogoutCommandHandler");
            this.Bind<ICommandHandler>().To<AddCommentCommandHandler>().Named("AddCommentCommandHandler");
            this.Bind<ICommandHandler>().To<AddVehicleCommandHandler>().Named("AddVehicleCommandHandler");
            this.Bind<ICommandHandler>().To<ShowUsersCommandHandler>().Named("ShowUsersCommandHandler");
            this.Bind<ICommandHandler>().To<ShowVehiclesCommandHandler>().Named("ShowVehiclesCommandHandler");
            this.Bind<ICommandHandler>().To<RemoveCommentCommandHandler>().Named("RemoveCommentCommandHandler");
            this.Bind<ICommandHandler>().To<RemoveVehicleCommandHandler>().Named("RemoveVehicleCommandHandler");

            this.Bind<IEngine>().To<DealershipEngine>().InSingletonScope();

            this.Bind<ICommandHandler>().ToMethod(ctx =>
            {
                var registerUserHandler = ctx.Kernel.Get<ICommandHandler>("RegisterUserCommandHandler");
                var loginHandler = ctx.Kernel.Get<ICommandHandler>("LoginCommandHandler");
                var logoutHandler = ctx.Kernel.Get<ICommandHandler>("LogoutCommandHandler");
                var addVehicleHandler = ctx.Kernel.Get<ICommandHandler>("AddVehicleCommandHandler");
                var removeVehicleHandler = ctx.Kernel.Get<ICommandHandler>("RemoveVehicleCommandHandler");
                var addCommnentHandler = ctx.Kernel.Get<ICommandHandler>("AddCommentCommandHandler");
                var removeCommentHandler = ctx.Kernel.Get<ICommandHandler>("RemoveCommentCommandHandler");
                var showUsersHandler = ctx.Kernel.Get<ICommandHandler>("ShowUsersCommandHandler");
                var showVehiclesHandler = ctx.Kernel.Get<ICommandHandler>("ShowVehiclesCommandHandler");

                registerUserHandler.AddCommandHandler(loginHandler);
                loginHandler.AddCommandHandler(logoutHandler);
                logoutHandler.AddCommandHandler(addVehicleHandler);
                addVehicleHandler.AddCommandHandler(removeVehicleHandler);
                removeVehicleHandler.AddCommandHandler(addCommnentHandler);
                addCommnentHandler.AddCommandHandler(removeCommentHandler);
                removeCommentHandler.AddCommandHandler(showUsersHandler);
                showUsersHandler.AddCommandHandler(showVehiclesHandler);

                return registerUserHandler;
            })
            .WhenInjectedInto<DealershipEngine>()
            .InSingletonScope();

            // this.Bind<IEngine>().To<DealershipEngine>().InSingletonScope();
        }
    }
}
