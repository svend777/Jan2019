using System;

namespace SharedData
{
    public static class AppSecrets
    {

        /* These are the secrets that would populated based on the user and the environment involved (QA1, QA2, Staging1, Prod1, ...).
         In this case, I'm pulling the 1st one from a local env variable, but we'd probably use using soething like Spring Cloud via SteelToe, 
         Azure Key Vault, etc.  */
        public static string CroweExercise_ConnString_SqlServer { get; set; }
        public static string CroweExercise_ConnString_Oracle { get; set; }
        public static string CroweExercise_Execution_Env { get; set; }

        public static string CroweExercise_UserId { get; set; }
        public static string CroweExercise_UserPassword { get; set; }

        public static string CroweExercise_Api_Token { get; set; }

        public static string CroweExercise_Api_EndPoint_Catalog { get; set; }
        public static string CroweExercise_Api_EndPoint_Subscriber { get; set; }
        public static string CroweExercise_Api_EndPoint_Security { get; set; }

        // etc.

    }
}
