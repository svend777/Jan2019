using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Misc;

namespace OracleLoggingService
{
    public class OracleLoggingService: ILoggingService
    {

        static void Main(string[] args)
        {

    
        }

        public bool LoggingWasSuccessful(string msg, string env, DateTime createDateTime)
        {
            try
            {
                // The connection string for the Oracle is being pulled from an environment variable.

                string connectionString = SharedData.AppSecrets.CroweExercise_ConnString_Oracle;

                /* Imagine code for writing to a table in Oracle*/

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
