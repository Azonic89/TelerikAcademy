namespace EventsRefactored
{
    using System;

    using Events.Entities.Models;

    public class StartUp
    {
        private static EventContainer events = new EventContainer();

        public static void Main()
        {
            while (ExecuteNextCommand())
            {
            }

            Console.WriteLine(Messages.Output);
        }

        private static bool ExecuteNextCommand()
        {
            var command = Console.ReadLine();
            switch (command[0])
            {
                case 'A':
                    AddEvent(command);
                    return true;
                case 'D':
                    DeleteEvents(command);
                    return true;
                case 'L':
                    ListEvents(command);
                    return true;
                case 'E':
                    return false;
                default:
                    return false;
            }
        }

        private static void ListEvents(string command)
        {
            var pipeIndex = command.IndexOf('|');
            var date = GetDate(command, "ListEvents");
            var countString = command.Substring(pipeIndex + 1);
            var count = int.Parse(countString);
            events.ListEvents(date, count);
        }

        private static void DeleteEvents(string command)
        {
            var title = command.Substring("DeleteEvents".Length + 1);
            events.DeleteEvents(title);
        }

        private static void AddEvent(string command)
        {
            DateTime date;
            string title;
            string location;

            GetParameters(command, "AddEvent", out date, out title, out location);

            events.AddEvent(date, title, location);
        }

        private static void GetParameters(
            string commandForExecution,
            string commandType,
            out DateTime dateAndTime,
            out string eventTitle,
            out string eventLocation)
        {
            dateAndTime = GetDate(commandForExecution, commandType);
            var firstPipeIndex = commandForExecution.IndexOf('|');

            var lastPipeIndex = commandForExecution.LastIndexOf('|');
            if (firstPipeIndex == lastPipeIndex)
            {
                eventTitle = commandForExecution
                    .Substring(firstPipeIndex + 1)
                    .Trim();
                eventLocation = string.Empty;
            }
            else
            {
                eventTitle = commandForExecution
                    .Substring(firstPipeIndex + 1, lastPipeIndex - firstPipeIndex - 1)
                    .Trim();
                eventLocation = commandForExecution.Substring(lastPipeIndex + 1).Trim();
            }
        }

        private static DateTime GetDate(string command, string commandType)
        {
            var date = DateTime.Parse(command.Substring(commandType.Length + 1, 20));

            return date;
        }
    }
}
