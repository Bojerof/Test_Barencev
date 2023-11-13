using NUnit.Framework;

namespace Work_2.Work
{
    [TestFixture]
    public class GroupRemove : TestBase
    {
        [Test]
        public void GroupRemoveTest()
        {
            OpenHomePage();
            Login(new AccountDate("admin", "secret"));
            GotoGroupsPage();
            SelectGroup(1);
            RemoveGroup();
            GotoGroupsPage();
        }
    }
}