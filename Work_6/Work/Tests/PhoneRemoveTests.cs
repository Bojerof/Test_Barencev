using System;
using NUnit.Framework;

namespace Work_6.Work
{
	[TestFixture]
	public class PhoneRemoveTests : AuthTestBase
	{
		[Test]
		public void PhoneRemoveTest()
		{
			List<ContactData> oldPhone = app.Contacts.GetPhoneList();

			app.Contacts.RemovePhone(0);

            List<ContactData> newPhone = app.Contacts.GetPhoneList();

			oldPhone.RemoveAt(0);

			Assert.AreEqual(oldPhone, newPhone);
        }
	}
}

