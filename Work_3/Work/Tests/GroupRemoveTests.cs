using NUnit.Framework;

namespace Work_3.Work
{
    [TestFixture]
    public class GroupRemoveTests : AuthTestBase
    {
        [Test]
        public void GroupRemoveTest()
        {
            app.Groups.Remove(1);
        }
    }
}