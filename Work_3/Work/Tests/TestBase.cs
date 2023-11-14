using System;
using NUnit.Framework;
namespace Work_3.Work
{
	public class TestBase
    { 
        protected ApplicationManager app;

        [SetUp]
        public void SetupTest()
        {
            app = ApplicationManager.GetInstance();

        }
    }
}

