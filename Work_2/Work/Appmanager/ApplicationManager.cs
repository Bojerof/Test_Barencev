using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Work_2.Work
{
	public class ApplicationManager
	{
        protected LoginHelper loginHelper;
        protected NavigationHelper navigation;
        protected GroupHelper groupHelper;

        protected IWebDriver driver = new ChromeDriver();
        protected string baseURL = "http://localhost/addressbook/group.php";

        public ApplicationManager()
        {
            loginHelper = new LoginHelper(driver);
            navigation = new NavigationHelper(driver, baseURL);
            groupHelper = new GroupHelper(driver);
        }

        public void Stop()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

        public LoginHelper Auth { get => loginHelper; set => loginHelper = value; }

        public NavigationHelper Navigator { get => navigation; set => navigation = value; }

        public GroupHelper Group { get => groupHelper; set => groupHelper = value; }
    }
}

