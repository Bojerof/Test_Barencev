using System;
using NUnit.Framework;

namespace Work_6.Work
{
	[TestFixture]
	public class ContactInformationTest : AuthTestBase
	{
		[Test]
		public void TestcCntactInformation()
		{
            ContactData fromTable = app.Contacts.GetContactInformationFromTable(0);
            ContactData fromForm = app.Contacts.GetContactInformationFromEditForm(0);
			ContactData fromInfoTable = app.Contacts.GetContactInfomationFromInfoTable(0);


			Assert.AreEqual(fromTable, fromForm);
			Assert.AreEqual(fromTable.Address, fromForm.Address);
			Assert.AreEqual(fromTable.AllPhones, fromForm.AllPhones);
			Assert.AreEqual(fromInfoTable, fromTable);
        }
	}
}

