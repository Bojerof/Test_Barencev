using OpenQA.Selenium;

namespace Work_3.Work
{
	public class LoginHelper : HelperBase
	{
        public LoginHelper(ApplicationManager manager) : base(manager) { }
        

        public void Login(AccountDate account)
        {
            Type(By.Name("user"), account.Username);
            Type(By.Name("pass"), account.Password);
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
        }
    }
}

