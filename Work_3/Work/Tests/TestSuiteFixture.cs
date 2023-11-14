using System;
using NUnit.Framework;

namespace Work_3.Work
{
    [SetUpFixture]
	public class TestSuiteFixture
	{
		
		[OneTimeSetUp]
		public void InitApplicationManager()
		{
            ApplicationManager app = ApplicationManager.GetInstance();

            app.Navigator.OpenHomePage();
            app.Auth.Login(new AccountDate("admin", "secret"));

        }
	}
}

