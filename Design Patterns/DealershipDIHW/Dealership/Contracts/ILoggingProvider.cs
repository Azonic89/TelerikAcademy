namespace Dealership.Contracts
{
    public interface ILoggingProvider
    {
        void WriteLine(string message);

        void Write(string message);

        string Read();
    }
}
