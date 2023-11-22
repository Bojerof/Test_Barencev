using OpenQA.Selenium;

namespace Work_6.Work
{
	public class NavigationHelper : HelperBase
	{
        
        private string baseURL;

        public NavigationHelper(ApplicationManager manager, string baseURL) : base(manager)
        {
            this.baseURL = baseURL;
        }

        public void OpenHomePage()
        {
            if (driver.Url == baseURL)
            {
                return;
            }
            driver.Navigate().GoToUrl(baseURL);
        }

        public void GotoGroupsPage()
        {
            if (driver.Url == baseURL + "/group.php"
                && IsElementPresent(By.Name("new")))
            {
                return;
            }
            driver.FindElement(By.LinkText("groups")).Click();
        }

        public void GotoHomePage()
        {
            if (driver.Url == baseURL)
            {
                return;
            }
            driver.FindElement(By.LinkText("home")).Click();
        }

        //Homework
        public void GoToAddNew()
        {
            if (driver.Url == baseURL + "/edit.php"
                && IsElementPresent(By.Name("submit")))
            {
                return;
            }
            driver.FindElement(By.LinkText("add new")).Click();
        }
    }
}

