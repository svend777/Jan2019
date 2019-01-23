using System;
using System.Collections.Generic;
using System.Text;

namespace Misc
{
    public class  LogAction
    {
        private readonly ILoggingService loggingChannel;

        public LogAction(ILoggingService loggingChannel)
        {
            this.loggingChannel = loggingChannel;
        }

        public bool LoggingWasSuccessful(string msg, string env, DateTime createDateTime)
        {
            return this.loggingChannel.LoggingWasSuccessful(msg, env, createDateTime);
        }
    }
}
