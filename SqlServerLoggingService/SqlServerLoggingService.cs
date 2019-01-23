using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Misc;

namespace SqlServerLoggingService
{
    public class SqlServerLoggingService: ILoggingService
    {

        static void Main(string[] args)
        {

    
        }

        public bool LoggingWasSuccessful(string msg, string env, DateTime createDateTime)
        {
            try
            {
                // The connection string for the SQL connection is being pulled from an environment variable.

                string connectionString = SharedData.AppSecrets.CroweExercise_ConnString_SqlServer;

                /* Imagine code for writing to a table in SQL Server */

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
