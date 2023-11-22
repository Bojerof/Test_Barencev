using System;
using NUnit.Framework;

namespace Work_6.Work
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

            List<ContactData> oldPhone = app.Contacts.GetPhoneList();

            app.Contacts.ModifyPhone(0, phone);

            List<ContactData> newPhone = app.Contacts.GetPhoneList();
            oldPhone[0].Fistname = phone.Fistname;
            oldPhone[0].Lastname = phone.Lastname;
            oldPhone[0].Middlename = phone.Middlename;
            oldPhone[0].Nickname = phone.Nickname;
            oldPhone[0].Bday = phone.Bday;
            oldPhone[0].Bmonth = phone.Bmonth;
            oldPhone[0].Byear = phone.Byear;
            oldPhone[0].Aday = phone.Aday;
            oldPhone[0].Amonth = phone.Amonth;
            oldPhone[0].Ayear = phone.Ayear;
            oldPhone.Sort();
            newPhone.Sort();
            Assert.AreEqual(oldPhone, newPhone);
        }
	}
}

