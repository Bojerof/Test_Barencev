using System;
using NUnit.Framework;
using OpenQA.Selenium;
namespace Work_2.Work
{
	public class TestBase
    { 
        protected ApplicationManager app;

        [SetUp]
        public void SetupTest()
        {
            app = new ApplicationManager();
        }

        [TearDown]
        public void TeardownTest()
        {
            app.Stop();
        }
    }
}

