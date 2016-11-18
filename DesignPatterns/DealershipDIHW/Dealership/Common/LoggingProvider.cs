namespace Dealership.Common
{
    using System;

    using Contracts;

    public class LoggingProvider : ILoggingProvider
    {
        private readonly Action<string> write;
        private readonly Func<string> read;

        public LoggingProvider(Action<string> write, Func<string> read)
        {          
            this.write = write;
            this.read = read;
        }

        public void WriteLine(string message)
        {
            this.write(message);
            this.write(Environment.NewLine);
        }

        public void Write(string message)
        {
            this.write(message);
        }

        public string Read()
        {
            var input = this.read();
            return input;
        }
    }
}
