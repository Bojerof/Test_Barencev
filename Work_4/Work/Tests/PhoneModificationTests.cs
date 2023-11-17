using System;
using NUnit.Framework;

namespace Work_4.Work
{
	[TestFixture]
	public class PhoneModificationTests : AuthTestBase
	{
		[Test]
		public void PhoneModificationTest()
		{
			ContactData phone = new ContactData();
            phone.Fistname = "T";
            phone.Lastname = "T";
            phone.Middlename = "A";
            phone.Nickname = "T";
            phone.Bday = "2";
            phone.Bmonth = "March";
            phone.Byear = "1992";
            phone.Aday = "2";
            phone.Amonth = "March";
            phone.Ayear = "1992";

            List<ContactData> oldPhone = app.Groups.GetPhoneList();

            app.Groups.ModifyPhone(0, phone);

            List<ContactData> newPhone = app.Groups.GetPhoneList();

            Assert.AreEqual(oldPhone, newPhone);
        }
	}
}

