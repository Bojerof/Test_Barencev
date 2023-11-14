using System;
using NUnit.Framework;

namespace Work_3.Work
{
	[TestFixture]
	public class GroupModificationTests : AuthTestBase
    {
		[Test]
		public void GroupModificationTest()
		{
			GroupDate newData = new GroupDate("zzz");
			newData.Header = null;
			newData.Footer = null;

			app.Groups.Modify(1, newData);

		}
	}
}

