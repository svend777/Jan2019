using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Misc;

namespace ConsoleApp1
{
    public class ConsoleLoggingService: ILoggingService
    {

        static void Main(string[] args)
        {}

        public bool LoggingWasSuccessful(string msg, string env, DateTime createDateTime)
        {
            try
            {
                Debug.WriteLine($"{createDateTime.ToString("MM/dd/yyyy HH:mm:ss")} - {env} - {msg}");
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
