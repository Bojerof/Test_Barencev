using System;
using NUnit.Framework;
namespace Work_4.Work
{
	public class TestBase
    { 
        protected ApplicationManager app;

        [SetUp]
        public void SetupApplicationManager()
        {
            app = TestFixture.app;
        }


    }
}

