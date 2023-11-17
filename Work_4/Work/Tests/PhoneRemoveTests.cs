using System;
using NUnit.Framework;

namespace Work_4.Work
{
	[TestFixture]
	public class PhoneRemoveTests : AuthTestBase
	{
		[Test]
		public void PhoneRemoveTest()
		{
			List<ContactData> oldPhone = app.Groups.GetPhoneList();

			app.Groups.RemovePhone(0);

            List<ContactData> newPhone = app.Groups.GetPhoneList();

			oldPhone.RemoveAt(0);

			Assert.AreEqual(oldPhone, newPhone);
        }
	}
}

