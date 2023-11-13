using NUnit.Framework;

namespace Work_2.Work
{
    [TestFixture]
    public class GroupCreationTests : TestBase
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

            GroupDate group = new GroupDate("");
            group.Header = "";
            group.Footer = "";
            app.Groups.Create(group);
        }
    }
}