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
            loginHelper = new LoginHelper(this);
            navigation = new NavigationHelper(this, baseURL);
            groupHelper = new GroupHelper(this);
        }

        public IWebDriver Driver { get => driver; set => driver = value; }

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

        public GroupHelper Groups { get => groupHelper; set => groupHelper = value; }
    }
}

