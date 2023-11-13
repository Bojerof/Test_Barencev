using NUnit.Framework;

namespace Work_2.Work
{
    [TestFixture]
    public class GroupRemoveTests : TestBase
    {
        [Test]
        public void GroupRemoveTest()
        {
            app.Navigator.OpenHomePage();
            app.Auth.Login(new AccountDate("admin", "secret"));
            app.Navigator.GotoGroupsPage();
            app.Group.SelectGroup(1);
            app.Group.RemoveGroup();
            app.Navigator.GotoGroupsPage();
        }
    }
}