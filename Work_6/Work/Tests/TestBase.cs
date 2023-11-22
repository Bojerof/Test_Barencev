using System;
using System.Text;
using NUnit.Framework;
namespace Work_6.Work
{
    public class TestBase
    {
        protected ApplicationManager app;

        [SetUp]
        public void SetupApplicationManager()
        {
            app = TestFixture.app;
        }

        private static readonly string ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
        "abcdefghijklmnopqrstuvwxyz";
        private static Random rnd = new Random();
        public static string GenerateRandomString(int length)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                int index = rnd.Next(ALPHABET.Length);
                builder.Append(ALPHABET[index]);
            }
            return builder.ToString();
        }
    }
}

