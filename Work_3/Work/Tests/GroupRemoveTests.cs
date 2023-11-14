using NUnit.Framework;

namespace Work_3.Work
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