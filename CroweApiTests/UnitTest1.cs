using System;
using NUnit.Framework;
using CroweExercise.Controllers;
using CroweExercise.Models;


namespace Tests
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void LogOperationWasSuccessful()
        {
            var service = new LoggingController();
            var wasSuccessful=service.LogAndGetSuccessStatus();
            Assert.That(wasSuccessful, Is.True);
        }




    }
}