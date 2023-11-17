using System.Security.Cryptography;
using NUnit.Framework;

namespace Work_3.Work
{
    [TestFixture]
    public class GroupCreationTests : AuthTestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            GroupDate group = new GroupDate("aaa");
            group.Header = "ddd";
            group.Footer = "fff";


            List<GroupDate> oldGroups = app.Groups.GitGroupList();

            app.Groups.Create(group);

            List<GroupDate> newGroups = app.Groups.GitGroupList();

            Assert.AreEqual(oldGroups.Count + 1, newGroups.Count());
        }

        [Test]
        public void EmptyGroupCreationTest()
        {

            GroupDate group = new GroupDate("f");
            group.Header = "g";
            group.Footer = "h";

            List<GroupDate> oldGroups = app.Groups.GitGroupList();
            app.Groups.Create(group);

            List<GroupDate> newGroups = app.Groups.GitGroupList();

            Assert.AreEqual(oldGroups.Count + 1, newGroups.Count());
        }
    }
}