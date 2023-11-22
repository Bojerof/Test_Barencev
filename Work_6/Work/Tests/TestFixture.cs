using System;
using NUnit.Framework;

namespace Work_6.Work
{
	[SetUpFixture]
	public class TestFixture
	{
        public static ApplicationManager app;

        [OneTimeSetUp]
        public void RunApplicationManager()
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

