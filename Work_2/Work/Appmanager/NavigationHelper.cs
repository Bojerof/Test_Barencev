using OpenQA.Selenium;

namespace Work_2.Work
{
	public class NavigationHelper : HelperBase
	{
        
        private string baseURL;

        public NavigationHelper(IWebDriver driver, string baseURL) : base(driver)
        {
            this.baseURL = baseURL;
        }

        public void OpenHomePage()
        {
            driver.Navigate().GoToUrl(baseURL);
        }

        public void GotoGroupsPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }
    }
}

