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
            app.Navigator.OpenHomePage();
            app.Auth.Login(new AccountDate("admin", "secret"));
        }

        [TearDown]
        public void TeardownTest()
        {
            app.Stop();
        }
    }
}

