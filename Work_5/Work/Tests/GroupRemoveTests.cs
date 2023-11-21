using NUnit.Framework;

namespace Work_5.Work
{
    [TestFixture]
    public class GroupRemoveTests : AuthTestBase
    {
        [Test]
        public void GroupRemoveTest()
        {

            List<GroupData> oldGroups = app.Groups.GetGroupList();
            GroupData oldDate = oldGroups[0];

            app.Groups.RemoveGroup(0);

            Assert.AreEqual(oldGroups.Count - 1, app.Groups.GetGroupCounte());

            List<GroupData> newGroups = app.Groups.GetGroupList();

            oldGroups.RemoveAt(0);
            

            foreach (GroupData group in newGroups)
            {
                Assert.AreNotEqual(group.Id, oldDate);
            }
        }
    }
}