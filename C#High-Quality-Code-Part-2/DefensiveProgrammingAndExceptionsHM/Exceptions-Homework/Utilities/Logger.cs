﻿using System;
using System.Collections.Generic;

using Exceptions_Homework.Contracts;

namespace Exceptions_Homework.Utilities
{
    public class Logger : ILogger
    {
        private ICollection<string> messages;

        public Logger()
        {
            this.messages = new LinkedList<string>();
        }

        public IEnumerable<string> Messages
        {
            get
            {
                var output = new List<string>(this.messages);
                return output;
            }
        }

        public void Log(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                throw new ArgumentNullException($"message cannot be null or empty!!!");
            }

            this.messages.Add(message);
        }

        public override string ToString()
        {
            var parsedMessages = string.Join(Environment.NewLine, this.messages);

            return parsedMessages;
        }
    }
}
