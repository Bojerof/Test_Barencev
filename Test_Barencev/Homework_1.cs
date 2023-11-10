using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
namespace Selenium
{
    [TestFixture]
    public class TestCaseDialog
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        private User user;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            baseURL = "https://stats.tis-dialog.ru/index.php";
            verificationErrors = new StringBuilder();
            user = new User("2730453", "27304532730453");
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheUntitledTestCaseTest()
        {
            OpenWebSite();
            InputLogin();
            InputPassword();
            InputCategories();
            OutWebSite();
        }

        private void OutWebSite()
        {
            driver.FindElement(By.XPath("//a[@id='exitlink']/span")).Click();
        }

        private void InputCategories()
        {
            driver.FindElement(By.LinkText("Услуги")).Click();
        }

        private void InputPassword()
        {
            driver.FindElement(By.Name("passv")).Clear();
            driver.FindElement(By.Name("passv")).SendKeys(user.Password);
            driver.FindElement(By.Name("passv")).SendKeys(Keys.Enter);
        }

        private void InputLogin()
        {
            driver.FindElement(By.Name("login")).Click();
            driver.FindElement(By.Name("login")).Clear();
            driver.FindElement(By.Name("login")).SendKeys(user.Login);
        }

        private void OpenWebSite()
        {
            driver.Navigate().GoToUrl(baseURL);
        }

        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}