using System;
using System.Security.Cryptography;
using NUnit.Framework;

namespace Work_6.Work
{
	[TestFixture]
	public class GroupModificationTests : AuthTestBase
    {
		[Test]
		public void GroupModificationTest()
		{
			GroupData newData = new GroupData("zzz");
			newData.Header = null;
			newData.Footer = null;

            List<GroupData> oldGroups = app.Groups.GetGroupList();
            GroupData oldDate = oldGroups[0];

            app.Groups.ModifyGroup(0, newData);

            Assert.AreEqual(oldGroups.Count, app.Groups.GetGroupCounte());

            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups[0].Name = newData.Name;
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);

            foreach (GroupData group in newGroups)
            {
                if (group.Id == oldDate.Id)
                {
                    Assert.AreEqual(newData.Name, group.Name);
                }
            }
        }
	}
}

