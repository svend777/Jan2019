using System;
using System.Collections.Generic;
using System.Text;

namespace Misc
{
    public interface ILoggingService
    {
        bool LoggingWasSuccessful(string msg, string env, DateTime createDateTime);
    }
}
