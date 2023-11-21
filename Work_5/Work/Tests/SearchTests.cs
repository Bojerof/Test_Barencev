using System;
using NUnit.Framework;

namespace Work_5.Work
{
	[TestFixture]
	public class SearchTests : AuthTestBase
	{
		[Test]
		public void TestSearch()
		{
			Console.WriteLine(app.Contacts.GetNumberSearchResults());
		}
	}
}

