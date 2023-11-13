using NUnit.Framework;

namespace Work_2.Work
{
    [TestFixture]
    public class GroupCreation : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            OpenHomePage();
            Login(new AccountDate("admin", "secret"));
            GotoGroupsPage();
            InitNewGroupCreation();
            FillGroupForm(new GroupDate("aaa", "ddd", "fff"));
            SubmitGroupCreation();
            GotoGroupsPage();
        }
    }
}