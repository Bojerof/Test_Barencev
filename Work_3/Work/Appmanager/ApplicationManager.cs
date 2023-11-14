using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Work_3.Work
{
	public class ApplicationManager
	{
        protected LoginHelper loginHelper;
        protected NavigationHelper navigation;
        protected GroupHelper groupHelper;

        protected IWebDriver driver = new ChromeDriver();
        protected string baseURL = "http://localhost/addressbook/group.php";

        private static ThreadLocal<ApplicationManager> app = new ThreadLocal<ApplicationManager>();

        private ApplicationManager()
        {
            loginHelper = new LoginHelper(this);
            navigation = new NavigationHelper(this, baseURL);
            groupHelper = new GroupHelper(this);
        }

        ~ApplicationManager()
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
        public static ApplicationManager GetInstance()
        {
            if (!app.IsValueCreated)
            {
                app.Value = new ApplicationManager();
            }
            return app.Value;
        }

        public IWebDriver Driver { get => driver; set => driver = value; }

        public LoginHelper Auth { get => loginHelper; set => loginHelper = value; }

        public NavigationHelper Navigator { get => navigation; set => navigation = value; }

        public GroupHelper Groups { get => groupHelper; set => groupHelper = value; }
    }
}

