using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Work_5.Work
{
	public class ApplicationManager
	{
        protected LoginHelper loginHelper;
        protected NavigationHelper navigation;
        protected GroupHelper groupHelper;
        protected ContactHelper contacts;

        protected IWebDriver driver = new ChromeDriver();
        protected string baseURL = "http://localhost/addressbook";

        private static ThreadLocal<ApplicationManager> app = new ThreadLocal<ApplicationManager>();

        public ApplicationManager()
        {
            loginHelper = new LoginHelper(this);
            navigation = new NavigationHelper(this, baseURL);
            groupHelper = new GroupHelper(this);
            contacts = new ContactHelper(this);
        }

        //Деструктор не отрабатывает
        //Как сделать чтобы он отрабатывал, я не понимаю
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
            if (! app.IsValueCreated)
            {
                ApplicationManager newInstance = new ApplicationManager();
                newInstance.Navigator.OpenHomePage();
                app.Value = newInstance;
            }
            return app.Value;
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

        public IWebDriver Driver { get => driver; set => driver = value; }

        public LoginHelper Auth { get => loginHelper; set => loginHelper = value; }

        public NavigationHelper Navigator { get => navigation; set => navigation = value; }

        public GroupHelper Groups { get => groupHelper; set => groupHelper = value; }

        public ContactHelper Contacts { get => contacts; set => contacts = value; }
    }
}

