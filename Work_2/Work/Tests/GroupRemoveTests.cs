using NUnit.Framework;

namespace Work_2.Work
{
    [TestFixture]
    public class GroupRemoveTests : TestBase
    {
        [Test]
        public void GroupRemoveTest()
        {
            app.Groups.Remove(1);   
        }
    }
}