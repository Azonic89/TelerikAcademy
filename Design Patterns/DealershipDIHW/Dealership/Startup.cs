namespace Dealership
{
    using System.Reflection;

    using Engine;

    using Ninject;

    public class Startup
    {
        public static void Main()
        {
            var ninject = new StandardKernel();
            ninject.Load(Assembly.GetExecutingAssembly());

            var engine = ninject.Get<IEngine>();
            engine.Start();
        }
    }
}
