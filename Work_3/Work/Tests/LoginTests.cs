using System;
using NUnit.Framework;

namespace Work_3.Work
{
	[TestFixture]
	public class LoginTests : TestBase
	{
		[Test]
		public void LoginWithValidCreation()
		{
			app.Auth.Logout();

			AccountDate account = new AccountDate("admin", "secret");
			app.Auth.Login(account);

			Assert.IsTrue(app.Auth.IsLoggedIn(account));
		}

		[Test]
		public void LoginWithInValidCreation()
		{
			app.Auth.Logout();

			AccountDate account = new AccountDate("admin", "12345");
			app.Auth.Login(account);

			Assert.IsFalse(app.Auth.IsLoggedIn(account));
		}
	}
}

