using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Misc;

namespace CroweExercise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoggingController : ControllerBase
    {
        // GET: api/Logging
        [HttpGet]
        public bool LogAndGetSuccessStatus()
        {
            var primaryLoggingService = new ConsoleLoggingService();

            var v = new LogAction(primaryLoggingService);

            return v.LoggingWasSuccessful("Hello world!", SharedData.AppSecrets.CroweExercise_Execution_Env, DateTime.UtcNow);

        }

    }
}
