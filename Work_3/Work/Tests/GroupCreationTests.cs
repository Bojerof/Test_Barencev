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
            app.Groups.Create(group);
        }

        [Test]
        public void EmptyGroupCreationTest()
        {

            GroupDate group = new GroupDate("f");
            group.Header = "g";
            group.Footer = "h";
            app.Groups.Create(group);
        }
    }
}