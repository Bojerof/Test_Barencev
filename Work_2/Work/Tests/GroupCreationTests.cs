using NUnit.Framework;

namespace Work_2.Work
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            app.Navigator.OpenHomePage();
            app.Auth.Login(new AccountDate("admin", "secret"));
            app.Navigator.GotoGroupsPage();
            app.Group.InitNewGroupCreation();
            app.Group.FillGroupForm(new GroupDate("aaa", "ddd", "fff"));
            app.Group.SubmitGroupCreation();
            app.Navigator.GotoGroupsPage();
        }
    }
}