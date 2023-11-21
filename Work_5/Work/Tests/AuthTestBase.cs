using System;
using NUnit.Framework;

namespace Work_5.Work
{

	public class AuthTestBase : TestBase
	{
		[SetUp]
		public void SetupLogin()
		{
			app.Auth.Login(new AccountDate("admin", "secret"));
		}
	}
}

