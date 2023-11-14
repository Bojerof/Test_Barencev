using System;
using NUnit.Framework;
namespace Work_3.Work
{
	public class TestBase
    { 
        protected ApplicationManager app;

        [SetUp]
        public void SetupApplicationManager()
        {
            app = ApplicationManager.GetInstance();
        }
        [OneTimeTearDown]
        public void StopApplicationManager()
        {
            app.Stop();
        }
    }
}

